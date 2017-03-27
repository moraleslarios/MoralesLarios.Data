using CKEstaticosDomain;
using MoralesLarios.Data.Dapper.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MoralesLarios.Data.IntegrationTests.Dapper.Infrastructure
{
    public class PartsQryGeneratorTests
    {
        private IPartsQryGenerator<GEHD_INCIDENCIAS> instance;



        public PartsQryGeneratorTests()
        {
            instance = new PartsQryGenerator<GEHD_INCIDENCIAS>();

            
        }



        [Fact]
        public void GeneratePartSelect_GoodParameters_OK()
        {
            var expected = @"SELECT " +
                                              "IdIncidencia" +
                        Environment.NewLine + ",Subject" +
                        Environment.NewLine + ",IdEntidad" +
                        Environment.NewLine + ",SubEntidad" +
                        Environment.NewLine + ",NombreContacto" +
                        Environment.NewLine + ",Concepto" +
                        Environment.NewLine + ",FechaAlta" +
                        Environment.NewLine + ",FechaCierre" +
                        Environment.NewLine + ",FechaModificacion" +
                        Environment.NewLine + ",FechaReportadoProveedor" +
                        Environment.NewLine + ",FechaCierreCECA" +
                        Environment.NewLine + ",Estado" +
                        Environment.NewLine + ",Prioridad" +
                        Environment.NewLine + ",IncidenciaPS" +
                        Environment.NewLine + ",IncidenciaCodCECA" +
                        Environment.NewLine + ",Bloque" +
                        Environment.NewLine + ",Persona" +
                        Environment.NewLine + ",PersonaCierre" +
                        Environment.NewLine + ",Incidencia" +
                        Environment.NewLine + ",Respuesta" +
                        Environment.NewLine + ",StatusProveedor" +
                        Environment.NewLine + ",IdDepartamento" +
                        Environment.NewLine + ",ComputaEstadisticas" +
                        Environment.NewLine + ",IdCorteServicio" +
                        Environment.NewLine + ",FechaReportadoInterno" +
                        Environment.NewLine + ",IdProducto" +
                        Environment.NewLine + ",FechaEstimada" +
                        Environment.NewLine + ",TextoBusquedaRapida" +
                      "FROM GEHD_INCIDENCIAS";

            string result = instance.GenerateSelect();

            string expectedWithoutComa = result.Replace(",", string.Empty);
            string resultWithoutComa = result.Replace(",", string.Empty);

            Assert.Equal(expectedWithoutComa, resultWithoutComa);

        }



        [Fact]
        public void GeneratePartInsert_WithParametersOneParameter_WithoutIdentityField_OK()
        {
            object parameter = new { IdIncidencia = 1000 };

            string expected = "INSERT INTO GEHD_INCIDENCIAS (IdIncidencia,Subject,IdEntidad,SubEntidad,NombreContacto,Concepto,FechaAlta,FechaCierre,FechaModificacion,FechaReportadoProveedor,FechaCierreCECA,Estado,Prioridad,IncidenciaPS, " +
                              "IncidenciaCodCECA,Bloque,Persona,PersonaCierre,Incidencia,Respuesta,StatusProveedor,IdDepartamento,ComputaEstadisticas,IdCorteServicio,FechaReportadoInterno,IdProducto,FechaEstimada,TextoBusquedaRapida) " +
            "VALUES " +
           "(@IdIncidencia,@Subject, @IdEntidad, @SubEntidad, @NombreContacto, @Concepto, @FechaAlta, @FechaCierre, @FechaModificacion, @FechaReportadoProveedor, @FechaCierreCECA, @Estado, @Prioridad, @IncidenciaPS, @IncidenciaCodCECA, " +
           "@Bloque, @Persona, @PersonaCierre, @Incidencia, @Respuesta, @StatusProveedor, @IdDepartamento, @ComputaEstadisticas, @IdCorteServicio, @FechaReportadoInterno, @IdProducto, @FechaEstimada, @TextoBusquedaRapida)";

            string identityField = null;

            string result = instance.GeneratePartInsert(identityField);

            var partialexpected = expected.Replace(" ", string.Empty);
            var partialresult = result.Replace(" ", string.Empty);

            Assert.Equal(partialexpected, partialresult);
        }

        [Fact]
        public void GeneratePartInsert_WithParametersOneParameter_AnotherSepartorChar_WithoutIdentityField_OK()
        {
            object parameter = new { IdIncidencia = 1000 };

            instance = new PartsQryGenerator<GEHD_INCIDENCIAS>(':');

            string expected = "INSERT INTO GEHD_INCIDENCIAS (IdIncidencia,Subject,IdEntidad,SubEntidad,NombreContacto,Concepto,FechaAlta,FechaCierre,FechaModificacion,FechaReportadoProveedor,FechaCierreCECA,Estado,Prioridad,IncidenciaPS, " +
                              "IncidenciaCodCECA,Bloque,Persona,PersonaCierre,Incidencia,Respuesta,StatusProveedor,IdDepartamento,ComputaEstadisticas,IdCorteServicio,FechaReportadoInterno,IdProducto,FechaEstimada,TextoBusquedaRapida) " +
            "VALUES " +
           "(:IdIncidencia,:Subject, :IdEntidad, :SubEntidad, :NombreContacto, :Concepto, :FechaAlta, :FechaCierre, :FechaModificacion, :FechaReportadoProveedor, :FechaCierreCECA, :Estado, :Prioridad, :IncidenciaPS, :IncidenciaCodCECA, " +
           ":Bloque, :Persona, :PersonaCierre, :Incidencia, :Respuesta, :StatusProveedor, :IdDepartamento, :ComputaEstadisticas, :IdCorteServicio, :FechaReportadoInterno, :IdProducto, :FechaEstimada, :TextoBusquedaRapida)";

            string identityField = null;

            string result = instance.GeneratePartInsert(identityField);

            var partialexpected = expected.Replace(" ", string.Empty);
            var partialresult = result.Replace(" ", string.Empty);

            Assert.Equal(partialexpected, partialresult);
        }

        [Fact]
        public void GeneratePartInsert_WithParametersOneParameter_WithIdentityField_OK()
        {
            object parameter = new { IdIncidencia = 1000 };

            string expected = "INSERT INTO GEHD_INCIDENCIAS (Subject,IdEntidad,SubEntidad,NombreContacto,Concepto,FechaAlta,FechaCierre,FechaModificacion,FechaReportadoProveedor,FechaCierreCECA,Estado,Prioridad,IncidenciaPS, " +
                              "IncidenciaCodCECA,Bloque,Persona,PersonaCierre,Incidencia,Respuesta,StatusProveedor,IdDepartamento,ComputaEstadisticas,IdCorteServicio,FechaReportadoInterno,IdProducto,FechaEstimada,TextoBusquedaRapida) " +
            "VALUES " +
           "(@Subject, @IdEntidad, @SubEntidad, @NombreContacto, @Concepto, @FechaAlta, @FechaCierre, @FechaModificacion, @FechaReportadoProveedor, @FechaCierreCECA, @Estado, @Prioridad, @IncidenciaPS, @IncidenciaCodCECA, " +
           "@Bloque, @Persona, @PersonaCierre, @Incidencia, @Respuesta, @StatusProveedor, @IdDepartamento, @ComputaEstadisticas, @IdCorteServicio, @FechaReportadoInterno, @IdProducto, @FechaEstimada, @TextoBusquedaRapida)";

            string identityField = "IdIncidencia";

            string result = instance.GeneratePartInsert(identityField);

            var partialexpected = expected.Replace(" ", string.Empty);
            var partialresult = result.Replace(" ", string.Empty);

            Assert.Equal(partialexpected, partialresult);
        }


        [Fact]
        public void GenerateRemove_WithParametersOneParameter_WithIdentityField_OK()
        {
            object parameter = new { IdIncidencia = 1000 };

            string expected = "DELETE FROM GEHD_INCIDENCIAS WHERE IDINCIDENCIA = @IdIncidencia";

            string result = instance.GenerateDelete(parameter);

            var partialexpected = expected.Replace(" ", string.Empty).ToUpper();
            var partialresult   = result  .Replace(" ", string.Empty).ToUpper();

            Assert.Equal(partialexpected, partialresult);
        }


        [Fact]
        public void GenerateSelect_WithParametersOneParameter_WithIdentityField_OK()
        {
            object pks = new { IdIncidencia = 1000 };

            var expected = @"SELECT " +
                                              "IdIncidencia" +
                        Environment.NewLine + ",Subject" +
                        Environment.NewLine + ",IdEntidad" +
                        Environment.NewLine + ",SubEntidad" +
                        Environment.NewLine + ",NombreContacto" +
                        Environment.NewLine + ",Concepto" +
                        Environment.NewLine + ",FechaAlta" +
                        Environment.NewLine + ",FechaCierre" +
                        Environment.NewLine + ",FechaModificacion" +
                        Environment.NewLine + ",FechaReportadoProveedor" +
                        Environment.NewLine + ",FechaCierreCECA" +
                        Environment.NewLine + ",Estado" +
                        Environment.NewLine + ",Prioridad" +
                        Environment.NewLine + ",IncidenciaPS" +
                        Environment.NewLine + ",IncidenciaCodCECA" +
                        Environment.NewLine + ",Bloque" +
                        Environment.NewLine + ",Persona" +
                        Environment.NewLine + ",PersonaCierre" +
                        Environment.NewLine + ",Incidencia" +
                        Environment.NewLine + ",Respuesta" +
                        Environment.NewLine + ",StatusProveedor" +
                        Environment.NewLine + ",IdDepartamento" +
                        Environment.NewLine + ",ComputaEstadisticas" +
                        Environment.NewLine + ",IdCorteServicio" +
                        Environment.NewLine + ",FechaReportadoInterno" +
                        Environment.NewLine + ",IdProducto" +
                        Environment.NewLine + ",FechaEstimada" +
                        Environment.NewLine + ",TextoBusquedaRapida" +
                      " FROM GEHD_INCIDENCIAS WHERE IDINCIDENCIA = @IdIncidencia";

            string result = instance.GenerateSelect(pks);

            var partialexpected = expected.Replace(" ", string.Empty).Replace(Environment.NewLine, string.Empty).ToUpper();
            var partialresult   = result.Replace(" ", string.Empty).Replace(Environment.NewLine, string.Empty).ToUpper();

            Assert.Equal(partialexpected, partialresult);
        }





        //[Fact]
        //public void GeneratePartRemove_ParametersInTable_OK()
        //{
        //    object parameters = new { IdIncidencia = 141484 };

        //    string expected = "DELETE FROM GEHD_INCIDENCIAS WHERE IDINCIDENCIA = @IdIncidencia";

        //    string result = instance.GeneratePartRemove(parameters);

        //    Assert.Equal(expected, result);

        //}




    }
}