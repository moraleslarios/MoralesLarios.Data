using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MoralesLarios.Data.Helper;
using System.Linq.Expressions;
using System.Linq;

namespace MoralesLarios.Data.EntityFramework
{
    internal class IncludeInjector<TEntity> : IIncludeInjector<TEntity> where TEntity : class
    {

        public DbQuery<TEntity> InjectorIncludes(DbQuery<TEntity> dbQry, params string[] includes)
        {
            ParameterValidator.ValidateObject(dbQry, nameof(dbQry));
            //ParameterValidator.ValidateEnumerableString(includes, nameof(includes));

            DbQuery<TEntity> result = dbQry;

            foreach (var include in includes)
            {
                result = result.Include(include);
            }

            return result;
        }

        public IQueryable<TEntity> InjectorIncludes<TProperty>(IQueryable<TEntity> dbQry, params Expression<Func<TEntity, TProperty>>[] paths)
        {
            ParameterValidator.ValidateObject(dbQry, nameof(dbQry));
            ParameterValidator.ValidateEnumerable(paths, nameof(paths));

            IQueryable<TEntity> result = dbQry;

            foreach (var path in paths)
            {
                result = result.Include<TEntity, TProperty>(path);
            }

            return result;
        }
    }
}