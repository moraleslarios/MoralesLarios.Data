using MoralesLarios.Data.EntityFramework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MoralesLarios.Data.IntegrationTests.EntityFramework.Infrastructure
{
    public class QryParametersManagerTests
    {
        private IQryParametersManager instance;


        private Dictionary<string, object> parametersInternal = new Dictionary<string, object>() { { "Telefono", 5 }, { "Mail", ".es" } };

        public QryParametersManagerTests()
        {
            instance = new QryParametersManager();
        }


        [Fact]
        public void GetParametersDictionary_GoodParameters_OK()
        {
            object parameters = new { Telefono = 5, Mail = ".es" };

            Dictionary<string, object> result = instance.GetParametersDictionary(parameters);

            Assert.Equal(result.Count, 2);
            Assert.Equal(result.First().Key, "Telefono");
            Assert.Equal(result.First().Value, 5);
            Assert.Equal(result.ElementAt(1).Key, "Mail");
            Assert.Equal(result.ElementAt(1).Value, ".es");
        }

        [Fact]
        public void GetParametersDictionary_ParametersNull_ThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => instance.GetParametersDictionary(null));
        }

        [Fact]
        public void GenerateStringQry_GoodParameters_OK()
        {
            string qry = $"Select * from Clientes where Telefono like '%@Telefono%' and mail like '%@Mail%'";

            var parameters = new Dictionary<string, object>() { { "Telefono", 5 }, { "Mail", ".es" } };

            string expected = "Select * from Clientes where Telefono like '%5%' and mail like '%.es%'";

            string result = instance.GenerateStringQry(qry, parameters);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void GenerateStringQry_NullQry_ThrowException(string qry)
        {
            Assert.Throws<ArgumentNullException>(() => instance.GenerateStringQry(qry, parametersInternal));
        }

        [Fact]
        public void GenerateStringQry_NullParameters_ThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => instance.GenerateStringQry("Select algo", null));
        }

    }
}
