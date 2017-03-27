using CKEstaticosDomain;
using MoralesLarios.Data.Dapper.Infrastructure;
using System;
using System.Data;
using System.Data.SqlClient;
using Xunit;

namespace MoralesLarios.Data.IntegrationTests.Dapper.Infrastructure
{
    public class IdentityInspectorTests
    {
        private IIDentityInspector<GEHD_INCIDENCIAS> instance;

        private IDbConnection conn;

        public IdentityInspectorTests()
        {
            conn = new SqlConnection(Settings.connectionString);

            instance = new IDentityInspector<GEHD_INCIDENCIAS>(conn);
        }



        [Fact]
        public void GetColumnsIdentityForType_GoodParameters_OK()
        {
            string expected = "IdIncidencia";

            string result = instance.GetColumnsIdentityForType();

            Assert.Equal(expected, result);
        }
    }
}
