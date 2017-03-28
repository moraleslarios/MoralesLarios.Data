using System;
using System.Data;
using System.Linq;
using Dapper;

namespace MoralesLarios.Data.Dapper.Infrastructure
{
    public class IDentityInspector<TEntity> : IIDentityInspector<TEntity> where TEntity : class
    {
        private IDbConnection conn;

        public IDentityInspector(IDbConnection conn)
        {
            this.conn = conn;
        }

        public string GetColumnsIdentityForType()
        {
            string result = null;

            string qry = $"select COLUMN_NAME " +
                            "from INFORMATION_SCHEMA.COLUMNS " +
                            "where COLUMNPROPERTY(object_id(TABLE_SCHEMA + '.' + TABLE_NAME), COLUMN_NAME, 'IsIdentity') = 1 " +
                            "and TABLE_NAME = @TableName " +
                            "order by TABLE_NAME";

            try
            {
                string tableName = typeof(TEntity).Name;

                result = conn.Query<string>(qry, new { TableName = tableName }).FirstOrDefault();
            }
            catch (Exception)
            {
                result = null;
            }

            return result;
        }
    }
}