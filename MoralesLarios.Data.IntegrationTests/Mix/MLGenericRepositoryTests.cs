using MoralesLarios.Data.Mix;
using MoralesLarios.Data.Dapper;
using MoralesLarios.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MoralesLarios.Data.IntegrationTests.Data;
using DataDomain;
using System.Linq.Expressions;

namespace MoralesLarios.Data.IntegrationTests.Mix
{
    public class MLGenericRepositoryTests : IDisposable
    {
        private MLGenericRepository<Clientes> instance;

        private DBModel context;

        public MLGenericRepositoryTests()
        {
            context = new DBModel();

            instance = new MLGenericRepository<Clientes>(context);
        }


        [Fact]
        public void Contructor_OneParameter_OK()
        {

        }




        #region GetData/Async

        [Fact]
        public void GetData_OneFilter_OK()
        {
            object filter = new { Nombre = "555555" };

            IEnumerable<Clientes> result = instance.GetData(filter);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetData_TwoFilters_OK()
        {
            object filter = new { FormaPago = "60 días", CIF = "000000009 " };

            IEnumerable<Clientes> result = instance.GetData(filter);

            Assert.NotNull(result);
        }

        [Fact]
        public async void GetDataAsync_TwoFilters_OK()
        {
            object filter = new { FormaPago = "60 días", CIF = "000000009 " };

            IEnumerable<Clientes> result = await instance.GetDataAsync(filter);

            Assert.NotNull(result);
        }


        [Fact]
        public void GetData_ByQry_OneFilter_OK()
        {
            object filter = new { Nombre = "Cliente 1" };

            string qry = "SELECT * FROM Clientes WHERE Nombre = '@Nombre'";

            IEnumerable<Clientes> result = instance.GetData(qry, filter);

            Assert.NotNull(result);
        }

        [Fact]
        public void GetData_WithoutInclude_OK()
        {
            context.Configuration.LazyLoadingEnabled = false;

            Expression<Func<Clientes, bool>> filter = a => a.IdCliente == 16;

            IEnumerable<Clientes> result = instance.GetData(filter);

            Assert.NotNull(result);
            Assert.Equal(1, result.Count());
        }

        [Fact]
        public void GetData_WithIncludes_OK()
        {
            context.Configuration.LazyLoadingEnabled = false;

            string include1 = "Facturas";
            string include2 = "PedidiosCliente";

            Expression<Func<Clientes, bool>> filter = a => a.IdCliente == 16;

            IEnumerable<Clientes> result = instance.GetData(filter, include2, include1);

            Assert.NotNull(result);

            if (result.Any())
            {
                Assert.NotNull(result.First().Facturas);
                Assert.NotNull(result.First().PedidiosCliente);
            }
        }

        [Fact]
        public async void GetDataAsync_QueryParametersVersion_GoodParameters_OK()
        {
            string qry = $"Select * from Clientes where Telefono like '%@Telefono%' and mail like '%@Mail%'";

            object parameters = new { Telefono = 5, Mail = ".es" };

            var result = await instance.GetDataAsync(qry, parameters);

            Assert.NotNull(result);
        }

        [Fact]
        public async void GetDataAsync_WithoutInclude_OK()
        {
            context.Configuration.LazyLoadingEnabled = false;

            Expression<Func<Clientes, bool>> filter = a => a.IdCliente == 16;

            IEnumerable<Clientes> result = await instance.GetDataAsync(filter);

            Assert.NotNull(result);
            Assert.Equal(1, result.Count());
        }

        [Fact]
        public async void GetDataAsync_WithIncludes_OK()
        {
            context.Configuration.LazyLoadingEnabled = false;

            string include1 = "Facturas";
            string include2 = "PedidiosCliente";

            Expression<Func<Clientes, bool>> filter = a => a.IdCliente == 16;

            IEnumerable<Clientes> result = await instance.GetDataAsync(filter, include2, include1);

            Assert.NotNull(result);

            if (result.Any())
            {
                Assert.NotNull(result.First().Facturas);
                Assert.NotNull(result.First().PedidiosCliente);
            }
        }

        #endregion

        #region Add-Multi/Async

        [Fact]
        public void Add_SimpleRow_OK()
        {
            Clientes entity = new Clientes { CIF = "000000001", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = instance.Add(entity);

            Assert.Equal(1, result);
        }

        [Fact]
        public async void AddAsync_SimpleRow_OK()
        {
            Clientes entity = new Clientes { CIF = "000000001", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = await instance.AddAsync(entity);

            Assert.Equal(1, result);
        }


        [Fact]
        public void Add_MultiRow_OK()
        {
            IEnumerable<Clientes> entities = new List<Clientes>()
            {
                new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" },
                new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" }
            };

            int result = instance.Add(entities);

            Assert.Equal(2, result);
        }

        [Fact]
        public async void AddAsync_MultiRow_OK()
        {
            IEnumerable<Clientes> entities = new List<Clientes>()
            {
                new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" },
                new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" }
            };

            int result = await instance.AddAsync(entities);

            Assert.Equal(2, result);
        }



        [Fact]
        public void AddEntiity_SimpleRow_OK()
        {
            Clientes cliente = new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            cliente = instance.AddEntity(cliente);

            Assert.NotEqual(cliente.IdCliente, default(int));
        }

        [Fact]
        public void AddEntity_EntityNull_ThrowException()
        {
            Clientes cliente = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                cliente = instance.AddEntity(cliente);
            });
        }

        [Fact]
        public void AddEntities_MultiRow_OK()
        {
            IEnumerable<Clientes> entities = new List<Clientes>()
            {
                new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" },
                new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" }
            };

            IEnumerable<Clientes> result = instance.AddEntities(entities);

            Assert.Equal(result.Count(), entities.Count());
            Assert.NotEqual(result.First().IdCliente, default(int));
            Assert.NotEqual(result.ElementAt(1).IdCliente, default(int));
        }


        #endregion

        #region Remove/Async

        [Fact]
        public void Remove_GoodKey_OK()
        {
            object key = new { IdCliente = 1837 };

            instance.Remove(key);
        }

        [Fact]
        public void Remove_BadParameter_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => instance.Remove(1980));
        }

        [Fact]
        public void Remove_KeyNull_ThrowException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                instance.Remove(null);
            });
        }

        [Fact]
        public async Task RemoveAsync_GoodKey_OK()
        {
            object key = new { IdCliente = 1838 };

            await instance.RemoveAsync(key);
        }


        #endregion

        #region All/Async

        [Fact]
        public void All_OK()
        {
            IEnumerable<Clientes> result = instance.All();

            Assert.NotNull(result);
        }


        [Fact]
        public async void AllAsync_OK()
        {
            IEnumerable<Clientes> result = await instance.AllAsync();

            Assert.NotNull(result);
        }

        #endregion

        #region Find/Async

        [Fact]
        public void Find_GoodFilter_OK()
        {
            object pkFields = new { IdCliente = 16 };

            Clientes result = instance.Find(pkFields);

            Assert.NotNull(result);
        }

        [Fact]
        public async void FindAsync_GoodFilter_OK()
        {
            object pkFields = new { IdCliente = 16 };

            Clientes result = await instance.FindAsync(pkFields);

            Assert.NotNull(result);
        }

        #endregion

        #region Update/Async

        [Fact]
        public void Update_GoodEntity_OK()
        {
            Clientes cliente = new Clientes
            {
                IdCliente = 1963,
                Nombre = "Cliente Cambiado",
                Direccion = "Sin Direccion",
                CIF = "A",
                Telefono = "1",
                Mail = "a@b.ces",
                FechaEntrada = DateTime.Today,
                FormaPago = "nada",
                PeriodoPago = 0
            };

            object pks = new { IdCliente = 1963 };

            int result = instance.Update(cliente, pks);

            Assert.Equal(1, result);
        }


        [Fact]
        public async void UpdateAsync_GoodEntity_OK()
        {
            Clientes cliente = new Clientes
            {
                IdCliente = 1963,
                Nombre = "Cliente Cambiado",
                Direccion = "Sin Direccion",
                CIF = "A",
                Telefono = "1",
                Mail = "a@b.ces",
                FechaEntrada = DateTime.Today,
                FormaPago = "nada",
                PeriodoPago = 0
            };

            object pks = new { IdCliente = 1963 };

            int result = await instance.UpdateAsync(cliente, pks);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Update_GoodEntiity_ExistsInDB_OK()
        {
            var entity = new Clientes { IdCliente = 1963, CIF = "000000009", Direccion = "changeddd", Nombre = "cambiado EF", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = instance.Update(entity);

            Assert.Equal(1, result);
        }

        #endregion

        #region InsertOrUpdate/Async

        [Fact]
        public void InsertOrUpdate_Insert_OK()
        {
            Clientes cliente = new Clientes
            {
                IdCliente = 1963,
                Nombre = "555555",
                Direccion = "Direccion nueva",
                CIF = "A",
                Telefono = "1",
                Mail = "a@b.ces",
                FechaEntrada = DateTime.Today,
                FormaPago = "nada",
                PeriodoPago = 0
            };

            object pks = new { IdCliente = 0 };

            int result = instance.InstertOrUpdate(cliente, pks);

            Assert.Equal(1, result);
        }

        [Fact]
        public void InsertOrUpdate_Update_OK()
        {
            Clientes cliente = new Clientes
            {
                IdCliente = 1976,
                Nombre = "Cliente Actualizado nuevo",
                Direccion = "Direccion nueva actualizada",
                CIF = "A",
                Telefono = "1",
                Mail = "a@b.ces",
                FechaEntrada = DateTime.Today,
                FormaPago = "nada",
                PeriodoPago = 0
            };

            object pks = new { IdCliente = 1976 };

            int result = instance.InstertOrUpdate(cliente, pks);

            Assert.Equal(1, result);
        }


        [Fact]
        public async void InsertOrUpdateAsync_Insert_OK()
        {
            Clientes cliente = new Clientes
            {
                IdCliente = 1963,
                Nombre = "Cliente Insertado nuevo",
                Direccion = "Direccion nueva",
                CIF = "A",
                Telefono = "1",
                Mail = "a@b.ces",
                FechaEntrada = DateTime.Today,
                FormaPago = "nada",
                PeriodoPago = 0
            };

            object pks = new { IdCliente = 0 };

            int result = instance.InstertOrUpdate(cliente, pks);

            Assert.Equal(1, result);
        }


        [Fact]
        public async void InsertOrUpdateAsync_Update_OK()
        {
            Clientes cliente = new Clientes
            {
                IdCliente = 1976,
                Nombre = "Cliente Actualizado nuevo",
                Direccion = "Direccion nueva actualizada",
                CIF = "A",
                Telefono = "1",
                Mail = "a@b.ces",
                FechaEntrada = DateTime.Today,
                FormaPago = "nada",
                PeriodoPago = 0
            };

            object pks = new { IdCliente = 1976 };

            int result = await instance.InstertOrUpdateAsync(cliente, pks);

            Assert.Equal(1, result);
        }



        [Fact]
        public void InsertOrUpdate_GoodEntity_Updated_OK()
        {
            var entity = new Clientes { IdCliente = 1963, CIF = "000000009", Direccion = "changeddd", Nombre = "EF InsertOrUpdate", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = instance.InstertOrUpdate(entity);

            Assert.Equal(1, result);
        }

        [Fact]
        public void InsertOrUpdate_GoodEntity_Inserted_OK()
        {
            var entity = new Clientes { IdCliente = 0, CIF = "000000009", Direccion = "newww", Nombre = "Insertado con InsertOrUpdate", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = instance.InstertOrUpdate(entity);

            Assert.Equal(1, result);
        }

        #endregion




        public void Dispose()
        {
            var removeDatas = instance.GetData(new { Nombre = "555555" });

            foreach (var item in removeDatas)
            {
                instance.Remove(new { item.IdCliente });
            }
        }
    }
}
