using DataDomain;
using MoralesLarios.Data.Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Dapper;

namespace MoralesLarios.Data.IntegrationTests.Dapper
{
    public class DPGenericRepositoryTets
    {
        private IDPGenericRepository<GEHD_INCIDENCIAS> instance;

        private IDbConnection conn;


        
        public DPGenericRepositoryTets()
        {
            conn = new SqlConnection(Settings.connectionString);

            instance = new DPGenericRepository<GEHD_INCIDENCIAS>(conn);
        }



        [Fact]
        public void Constructor_ConnectionNull_throwException()
        {
            conn = null;

            Assert.Throws<ArgumentNullException>(() => instance = new DPGenericRepository<GEHD_INCIDENCIAS>(conn));
        }



        #region All


        //[Fact]
        //public void All_OK()
        //{
        //    IEnumerable<GEHD_INCIDENCIAS> result = instance.All();

        //    Assert.NotNull(result);
        //}

        [Fact]
        public void All_OK()
        {
            conn = new SqlConnection(Settings.connectionString);

            var instance = new DPGenericRepository<GEIN_CORTES_SERVICIO>(conn);

            IEnumerable<GEIN_CORTES_SERVICIO> result = instance.All();

            Assert.NotNull(result);
        }

        #endregion

        #region AllAsync

        [Fact]
        public async void AllAsync_OK()
        {
            conn = new SqlConnection(Settings.connectionString);

            var instance = new DPGenericRepository<GEIN_CORTES_SERVICIO>(conn);

            IEnumerable<GEIN_CORTES_SERVICIO> result = await instance.AllAsync();

            Assert.NotNull(result);
        }

        #endregion

        #region GetData

        [Fact]
        public void GetData_OneFilter_OK()
        {
            object filter = new { IdIncidencia = 395 };

            IEnumerable<GEHD_INCIDENCIAS> result = instance.GetData(filter);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetData_ThreeFilters_OK()
        {
            object filter = new { concepto = "OPERACIONES", PRIORIDAD = 4, Bloque = "INCIDENCIA" };

            IEnumerable<GEHD_INCIDENCIAS> result = instance.GetData(filter);

            Assert.NotNull(result);
        }

        #endregion

        #region GetDataAsync

        [Fact]
        public async void GetDataAsync_ThreeFilters_OK()
        {
            object filter = new { concepto = "OPERACIONES", PRIORIDAD = 4, Bloque = "INCIDENCIA" };

            IEnumerable<GEHD_INCIDENCIAS> result = await instance.GetDataAsync(filter);

            Assert.NotNull(result);
        }

        #endregion

        #region Find

        [Fact]
        public void Find_GoodFilter_OK()
        {
            object pkFields = new { IdIncidencia = 395 };

            GEHD_INCIDENCIAS result = instance.Find(pkFields);

            Assert.NotNull(result);
        }

        #endregion

        #region FindAsync

        [Fact]
        public async void FindAsync_GoodFilter_OK()
        {
            object pkFields = new { IdIncidencia = 395 };

            GEHD_INCIDENCIAS result = await instance.FindAsync(pkFields);

            Assert.NotNull(result);
        }

        #endregion

        #region Add

        [Fact]
        public void Add_GoodParameter_OK()
        {
            GEHD_INCIDENCIAS incidencia = new GEHD_INCIDENCIAS
            {
                //IdIncidencia = 99999,
                Bloque = "b",
                ComputaEstadisticas = "s",
                Concepto = "c",
                Estado = "e",
                FechaAlta = DateTime.Today,
                FechaCierre = DateTime.Today,
                FechaCierreCECA = DateTime.Today,
                FechaEstimada = DateTime.Today,
                FechaModificacion = DateTime.Today,
                FechaReportadoInterno = DateTime.Today,
                FechaReportadoProveedor = DateTime.Today,
                IdCorteServicio = 1,
                IdDepartamento = "u",
                IdEntidad = "0000",
                IdProducto = 1,
                Incidencia = "i",
                IncidenciaCodCECA = "C",
                IncidenciaPS = "p",
                NombreContacto = "n",
                Persona = "p",
                PersonaCierre = "p",
                Prioridad = "p",
                Respuesta = "r",
                StatusProveedor = "s",
                SubEntidad = "s",
                Subject = "s",
                TextoBusquedaRapida = "s"
            };

            int result = instance.Add(incidencia);

            Assert.Equal(1, result);
        }


        //[Fact]
        //public void Add2_GoodParameter_OK()
        //{
        //    conn = new SqlConnection(Settings.connectionString);

        //    var instance = new DPGenericRepository<CKAH_FECHAS_HIS>(conn);

        //    var fechaHis = new CKAH_FECHAS_HIS
        //    {
        //        FechaBackup = DateTime.Today,
        //        FechaBorradoHis = DateTime.Today
        //    };

        //    int result = instance.Add(fechaHis);

        //    Assert.Equal(1, result);
        //}


        //[Fact]
        //public void Add_Multi_GoodParameter_OK()
        //{
        //    conn = new SqlConnection(Settings.connectionString);

        //    var instance = new DPGenericRepository<CKAH_FECHAS_HIS>(conn);

        //    var fechasHis = new List<CKAH_FECHAS_HIS>();

        //    for (int i = 0; i < 100; i++)
        //    {
        //        var fecha = new CKAH_FECHAS_HIS { FechaBackup = DateTime.Today.AddDays(1), FechaBorradoHis = DateTime.Today.AddDays(1) };

        //        fechasHis.Add(fecha);
        //    }

        //    int result = instance.Add(fechasHis);

        //    Assert.Equal(100, result);
        //}


        [Fact]
        public void Add3_GoodParameter_OK()
        {
            conn = new SqlConnection(Settings.connectionString);

            var instance = new DPGenericRepository<GEIN_CORTES_SERVICIO>(conn);

            var fechaHis = new GEIN_CORTES_SERVICIO
            {
                FechaInicio = DateTime.Today,
                FechaFin = DateTime.Today,
                IdDepartamento = "D",
                Incidencia = "i",
                Subject = "SBJ-2",
                Persona = "p"
            };

            int result = instance.Add(fechaHis);

            Assert.Equal(1, result);
        }



        #endregion

        #region AddAsync

        //[Fact]
        //public async void AddAsync_GoodParameter_OK()
        //{
        //    conn = new SqlConnection(Settings.connectionString);

        //    var instance = new DPGenericRepository<CKAH_FECHAS_HIS>(conn);

        //    var fechaHis = new CKAH_FECHAS_HIS
        //    {
        //        FechaBackup = DateTime.Today,
        //        FechaBorradoHis = DateTime.Today
        //    };

        //    int result = await instance.AddAsync(fechaHis);

        //    Assert.Equal(1, result);
        //}



        //[Fact]
        //public async void AddAsync_Multi_GoodParameter_OK()
        //{
        //    conn = new SqlConnection(Settings.connectionString);

        //    var instance = new DPGenericRepository<CKAH_FECHAS_HIS>(conn);

        //    var fechasHis = new List<CKAH_FECHAS_HIS>();

        //    for (int i = 0; i < 100; i++)
        //    {
        //        var fecha = new CKAH_FECHAS_HIS { FechaBackup = DateTime.Today.AddDays(1), FechaBorradoHis = DateTime.Today.AddDays(1) };

        //        fechasHis.Add(fecha);
        //    }

        //    int result = await instance.AddAsync(fechasHis);

        //    Assert.Equal(100, result);
        //}


        #endregion

        #region Update/Async

        [Fact]
        public void Update_GoodEntity_OK()
        {
            GEHD_INCIDENCIAS incidencia = new GEHD_INCIDENCIAS
            {
                IdIncidencia = 141485,
                Bloque = "x",
                ComputaEstadisticas = "c",
                Concepto = "c",
                Estado = "camb",
                FechaAlta = DateTime.Today,
                FechaCierre = DateTime.Today,
                FechaCierreCECA = DateTime.Today,
                FechaEstimada = DateTime.Today,
                FechaModificacion = DateTime.Today,
                FechaReportadoInterno = DateTime.Today,
                FechaReportadoProveedor = DateTime.Today,
                IdCorteServicio = 1,
                IdDepartamento = "u",
                IdEntidad = "0000",
                IdProducto = 1,
                Incidencia = "i",
                IncidenciaCodCECA = "C",
                IncidenciaPS = "p",
                NombreContacto = "n",
                Persona = "p",
                PersonaCierre = "p",
                Prioridad = "p",
                Respuesta = "r",
                StatusProveedor = "s",
                SubEntidad = "s",
                Subject = "s",
                TextoBusquedaRapida = "s"
            };

            object pks = new { IdIncidencia = 141485 };

            int result = instance.Update(incidencia, pks);

            Assert.Equal(1, result);
        }

        [Fact]
        public async void UpdateAsync_GoodEntity_OK()
        {
            GEHD_INCIDENCIAS incidencia = new GEHD_INCIDENCIAS
            {
                IdIncidencia = 141485,
                Bloque = "x",
                ComputaEstadisticas = "c",
                Concepto = "c",
                Estado = "camb",
                FechaAlta = DateTime.Today,
                FechaCierre = DateTime.Today,
                FechaCierreCECA = DateTime.Today,
                FechaEstimada = DateTime.Today,
                FechaModificacion = DateTime.Today,
                FechaReportadoInterno = DateTime.Today,
                FechaReportadoProveedor = DateTime.Today,
                IdCorteServicio = 1,
                IdDepartamento = "u",
                IdEntidad = "0000",
                IdProducto = 1,
                Incidencia = "i",
                IncidenciaCodCECA = "C",
                IncidenciaPS = "p",
                NombreContacto = "n",
                Persona = "p",
                PersonaCierre = "p",
                Prioridad = "p",
                Respuesta = "r",
                StatusProveedor = "s",
                SubEntidad = "s",
                Subject = "s",
                TextoBusquedaRapida = "s"
            };

            object pks = new { IdIncidencia = 141485 };

            int result = await instance.UpdateAsync(incidencia, pks);

            Assert.Equal(1, result);
        }


        #endregion

        #region InsertOrUpdate/Async

        [Fact]
        public void InsertOrUpdate_Insert_OK()
        {
            GEHD_INCIDENCIAS incidencia = new GEHD_INCIDENCIAS
            {
                IdIncidencia = 0,
                Bloque = "xXx",
                ComputaEstadisticas = "c",
                Concepto = "c",
                Estado = "camb",
                FechaAlta = DateTime.Today,
                FechaCierre = DateTime.Today,
                FechaCierreCECA = DateTime.Today,
                FechaEstimada = DateTime.Today,
                FechaModificacion = DateTime.Today,
                FechaReportadoInterno = DateTime.Today,
                FechaReportadoProveedor = DateTime.Today,
                IdCorteServicio = 1,
                IdDepartamento = "u",
                IdEntidad = "0000",
                IdProducto = 1,
                Incidencia = "i",
                IncidenciaCodCECA = "C",
                IncidenciaPS = "p",
                NombreContacto = "n",
                Persona = "p",
                PersonaCierre = "p",
                Prioridad = "p",
                Respuesta = "r",
                StatusProveedor = "s",
                SubEntidad = "s",
                Subject = "s",
                TextoBusquedaRapida = "s"
            };

            object pks = new { IdIncidencia = 0 };

            int result = instance.InstertOrUpdate(incidencia, pks);

            Assert.Equal(1, result);
        }

        [Fact]
        public void InsertOrUpdate_Update_OK()
        {
            GEHD_INCIDENCIAS incidencia = new GEHD_INCIDENCIAS
            {
                IdIncidencia = 141491,
                Bloque = "xXx",
                ComputaEstadisticas = "c",
                Concepto = "c",
                Estado = "camb",
                FechaAlta = DateTime.Today,
                FechaCierre = DateTime.Today,
                FechaCierreCECA = DateTime.Today,
                FechaEstimada = DateTime.Today,
                FechaModificacion = DateTime.Today,
                FechaReportadoInterno = DateTime.Today,
                FechaReportadoProveedor = DateTime.Today,
                IdCorteServicio = 1,
                IdDepartamento = "u",
                IdEntidad = "0000",
                IdProducto = 1,
                Incidencia = "i",
                IncidenciaCodCECA = "C",
                IncidenciaPS = "p",
                NombreContacto = "n",
                Persona = "p",
                PersonaCierre = "p",
                Prioridad = "p",
                Respuesta = "r",
                StatusProveedor = "s",
                SubEntidad = "s",
                Subject = "Cambiado",
                TextoBusquedaRapida = "s"
            };

            object pks = new { IdIncidencia = 0 };

            int result = instance.InstertOrUpdate(incidencia, pks);

            Assert.Equal(1, result);
        }

        [Fact]
        public async void InsertOrUpdateAsync_Insert_OK()
        {
            GEHD_INCIDENCIAS incidencia = new GEHD_INCIDENCIAS
            {
                IdIncidencia = 0,
                Bloque = "xXx",
                ComputaEstadisticas = "c",
                Concepto = "c",
                Estado = "camb",
                FechaAlta = DateTime.Today,
                FechaCierre = DateTime.Today,
                FechaCierreCECA = DateTime.Today,
                FechaEstimada = DateTime.Today,
                FechaModificacion = DateTime.Today,
                FechaReportadoInterno = DateTime.Today,
                FechaReportadoProveedor = DateTime.Today,
                IdCorteServicio = 1,
                IdDepartamento = "u",
                IdEntidad = "0000",
                IdProducto = 1,
                Incidencia = "i",
                IncidenciaCodCECA = "C",
                IncidenciaPS = "p",
                NombreContacto = "n",
                Persona = "p",
                PersonaCierre = "p",
                Prioridad = "p",
                Respuesta = "r",
                StatusProveedor = "s",
                SubEntidad = "s",
                Subject = "s",
                TextoBusquedaRapida = "s"
            };

            object pks = new { IdIncidencia = 0 };

            int result = await instance.InstertOrUpdateAsync(incidencia, pks);

            Assert.Equal(1, result);
        }

        [Fact]
        public async void InsertOrUpdateAsync_Update_OK()
        {
            GEHD_INCIDENCIAS incidencia = new GEHD_INCIDENCIAS
            {
                IdIncidencia = 141491,
                Bloque = "xXx",
                ComputaEstadisticas = "c",
                Concepto = "c",
                Estado = "camb",
                FechaAlta = DateTime.Today,
                FechaCierre = DateTime.Today,
                FechaCierreCECA = DateTime.Today,
                FechaEstimada = DateTime.Today,
                FechaModificacion = DateTime.Today,
                FechaReportadoInterno = DateTime.Today,
                FechaReportadoProveedor = DateTime.Today,
                IdCorteServicio = 1,
                IdDepartamento = "u",
                IdEntidad = "0000",
                IdProducto = 1,
                Incidencia = "i",
                IncidenciaCodCECA = "C",
                IncidenciaPS = "p",
                NombreContacto = "n",
                Persona = "p",
                PersonaCierre = "p",
                Prioridad = "p",
                Respuesta = "r",
                StatusProveedor = "s",
                SubEntidad = "s",
                Subject = "Cambiado",
                TextoBusquedaRapida = "s"
            };

            object pks = new { IdIncidencia = 0 };

            int result = await instance.InstertOrUpdateAsync(incidencia, pks);

            Assert.Equal(1, result);
        }


        #endregion



        [Fact]
        public void PruebasVisualizer()
        {
            instance = new DPGenericRepository<GEHD_INCIDENCIAS>(conn);

            var allData = instance.All();
        }





        [Fact]
        public void Remove_GoodEntity_OK()
        {
            object key = new { IdIncidencia = 141486 };

            instance.Remove(key);
        }




    }
}
