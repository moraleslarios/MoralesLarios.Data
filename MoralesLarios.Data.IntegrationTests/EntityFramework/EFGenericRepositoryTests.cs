using System;
using MoralesLarios.Data.EntityFramework;
using System.Data.Entity;
using MoralesLarios.Data.IntegrationTests.Data;
using Xunit;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace MoralesLarios.Data.IntegrationTests.EntityFramework
{

    public class EFGenericRepositoryTests : IDisposable
    {


        private DbContext context;

        private IEFGenericRepository<Clientes> instance;


        public EFGenericRepositoryTests()
        {
            context = new DBModel();

            instance = new EFGenericRepository<Clientes>(context);
        }

        [Fact]
        public void Constructor_ParameterContextNull_ThrowException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                instance = new EFGenericRepository<Clientes>(null);
            });

        }



        #region All

        [Fact]
        public void All_GoodParameters_OK()
        {
            context.Configuration.LazyLoadingEnabled = false;

            IEnumerable<Clientes> result = instance.All();

            Assert.NotNull(result);

            if (result.Any())
            {
                Assert.Null(result.First().Facturas);
                Assert.Null(result.First().PedidiosCliente);
            }
        }


        [Fact]
        public void All_WithIncludes_OK()
        {
            context.Configuration.LazyLoadingEnabled = false;

            string include1 = "Facturas";
            string include2 = "PedidiosCliente";

            IEnumerable<Clientes> result = instance.All(include2, include1);

            Assert.NotNull(result);

            if (result.Any())
            {
                Assert.NotNull(result.First().Facturas);
                Assert.NotNull(result.First().PedidiosCliente);
            }
        }

        #endregion

        #region AllAsync


        [Fact]
        public async void AllAsync_GoodParameters_OK()
        {
            context.Configuration.LazyLoadingEnabled = false;

            IEnumerable<Clientes> result = await instance.AllAsync();

            Assert.NotNull(result);

            if (result.Any())
            {
                Assert.Null(result.First().Facturas);
                Assert.Null(result.First().PedidiosCliente);
            }
        }

        [Fact]
        public async void AllAsync_WithIncludes_OK()
        {
            context.Configuration.LazyLoadingEnabled = false;

            string include1 = "Facturas";
            string include2 = "PedidiosCliente";

            IEnumerable<Clientes> result = await instance.AllAsync(include2, include1);

            Assert.NotNull(result);

            if (result.Any())
            {
                Assert.NotNull(result.First().Facturas);
                Assert.NotNull(result.First().PedidiosCliente);
            }
        }


        #endregion

        #region GetData

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
        public void GetData_WithoutIncludeAndFilterNull_ThrowException()
        {
            context.Configuration.LazyLoadingEnabled = false;

            Assert.Throws<ArgumentNullException>(() =>
            {
                IEnumerable<Clientes> result = instance.GetData(null);
            });

        }

        [Fact]
        public void GetData_QueryParametersVersion_GoodParameters_OK()
        {
            string qry = $"Select * from Clientes where Telefono like '%@Telefono%' and mail like '%@Mail%'";

            object parameters = new { Telefono = 5, Mail = ".es" };

            var result = instance.GetData(qry, parameters).ToList();

            Assert.NotNull(result);
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



        #endregion

        #region Find

        [Fact]
        public void Find_GoodFilter_OK()
        {
            object pkFields = new { IdCliente = 16 };

            Clientes result = instance.Find(pkFields);

            Assert.NotNull(result);
        }


        #endregion

        #region FindAsync

        [Fact]
        public async void FindAsync_GoodFilter_OK()
        {
            object pkFields = new { IdCliente = 16 };

            Clientes result = await instance.FindAsync(pkFields);

            Assert.NotNull(result);
        }

        #endregion

        #region GetDataAsync

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
        public void GetDataAsync_WithoutIncludeAndFilterNull_ThrowException()
        {
            context.Configuration.LazyLoadingEnabled = false;

            Assert.Throws<AggregateException>(() =>
            {
                IEnumerable<Clientes> result = instance.GetDataAsync(null).Result;
            });

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


        [Fact]
        public async void GetDataAsync_QueryParametersVersion_GoodParameters_OK()
        {
            string qry = $"Select * from Clientes where Telefono like '%@Telefono%' and mail like '%@Mail%'";

            object parameters = new { Telefono = 5, Mail = ".es" };

            var result = await instance.GetDataAsync(qry, parameters);

            Assert.NotNull(result);
        }


        #endregion

        #region Add

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


        [Fact]
        public void Add_SimpleRow_OK()
        {
            Clientes cliente = new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = instance.Add(cliente);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Add_EntityNull_ThrowException()
        {
            Clientes cliente = null;

            Assert.Throws<ArgumentNullException>(() =>
            {
                var result = instance.Add(cliente);
            });
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

        #endregion

        #region AddAsync

        [Fact]
        public async void AddEntityAsync_SimpleRow_OK()
        {
            Clientes cliente = new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            cliente = await instance.AddEntityAsync(cliente);

            Assert.NotEqual(cliente.IdCliente, default(int));
        }

        [Fact]
        public async void AddAsyncEntities_MultiRow_OK()
        {
            IEnumerable<Clientes> entities = new List<Clientes>()
            {
                new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" },
                new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" }
            };

            IEnumerable<Clientes> result = await instance.AddEntitiesAsync(entities);

            Assert.Equal(result.Count(), entities.Count());
            Assert.NotEqual(result.First().IdCliente, default(int));
            Assert.NotEqual(result.ElementAt(1).IdCliente, default(int));
        }


        [Fact]
        public async void AddAsync_SimpleRow_OK()
        {
            Clientes cliente = new Clientes { CIF = "000000009", Direccion = "to remove", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = await instance.AddAsync(cliente);

            Assert.Equal(1, result);
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


        #endregion

        #region Remove

        [Fact]
        public void Remove_GoodKey_OK()
        {
            object key = new { IdCliente = 312 };

            instance.Remove(key);
        }

        [Fact]
        public void Remove_ForEntity_GoodKey_OK()
        {
            var entity = new Clientes { IdCliente = 1947, Nombre = "555555", Direccion = "to remove", CIF = "000000009 ", Mail = "aa@eee.es" };

            instance.Remove(entity);
        }

        [Fact]
        public async void RemoveAsync_ForEntity_GoodKey_OK()
        {
            var entity = new Clientes { IdCliente = 1947, Nombre = "555555", Direccion = "to remove", CIF = "000000009 ", Mail = "aa@eee.es" };

            await instance.RemoveAsync(entity);
        }

        [Fact]
        public void Remove_KeyNull_ThrowException()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                instance.Remove(null);
            });
        }

        #endregion

        #region RemoveAsync

        [Fact]
        public async Task RemoveAsync_GoodKey_OK()
        {
            object key = new { IdCliente = 312 };

            await instance.RemoveAsync(key);
        }

        #endregion

        #region Update

        [Fact]
        public void Update_GoodEntiity_ExistsInDB_OK()
        {
            var entity = new Clientes { IdCliente = 1519, CIF = "000000009", Direccion = "changeddd", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = instance.Update(entity);

            Assert.Equal(1, result);
        }

        [Fact]
        public void Update_GoodEntiity_NotExistsInDB_ThrowException()
        {
            var entity = new Clientes { IdCliente = 0, CIF = "000000009", Direccion = "changeddd", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            Assert.Throws<DbUpdateConcurrencyException>(() => instance.Update(entity));
        }

        [Fact]
        public void Update_EntiityNull_ThrowException()
        {
            Assert.Throws<ArgumentNullException>(() => instance.Update(null));
        }


        #endregion

        #region UpdateAsync

        [Fact]
        public async void UpdateAsync_GoodEntity_OK()
        {
            var entity = new Clientes { IdCliente = 1519, CIF = "000000009", Direccion = "changeddd", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = await instance.UpdateAsync(entity, null);

            Assert.Equal(1, result);
        }

        [Fact]
        public void UpdateAsync_GoodEntiity_NotExistsInDB_ThrowException()
        {
            var entity = new Clientes { IdCliente = 0, CIF = "000000009", Direccion = "changeddd", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            Assert.ThrowsAsync<AggregateException>(async () => await instance.UpdateAsync(entity, null));
        }

        #endregion

        #region InsertOrUpdate

        [Fact]
        public void InsertOrUpdate_GoodEntity_Updated_OK()
        {
            var entity = new Clientes { IdCliente = 1519, CIF = "000000009", Direccion = "changeddd", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = instance.InstertOrUpdate(entity);

            Assert.Equal(1, result);
        }

        [Fact]
        public void InsertOrUpdate_GoodEntity_Inserted_OK()
        {
            var entity = new Clientes { IdCliente = 0, CIF = "000000009", Direccion = "newww", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = instance.InstertOrUpdate(entity);

            Assert.Equal(1, result);
        }

        #endregion

        #region InsertOrUpdateAsync

        [Fact]
        public async void InsertOrUpdateAsync_GoodEntity_Updated_OK()
        {
            var entity = new Clientes { IdCliente = 1519, CIF = "000000009", Direccion = "changeddd", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = await instance.InstertOrUpdateAsync(entity);

            Assert.Equal(1, result);
        }


        [Fact]
        public async void InsertOrUpdateAsync_GoodEntity_Inserted_OK()
        {
            var entity = new Clientes { IdCliente = 0, CIF = "000000009", Direccion = "newww Async", Nombre = "555555", Mail = "aa@eee.es", FechaEntrada = DateTime.Today, FormaPago = "60 días" };

            int result = await instance.InstertOrUpdateAsync(entity);

            Assert.Equal(1, result);
        }


        #endregion






        public void Dispose()
        {
            RemoveTestsInserts();

            context.Dispose();
        }


        private void RemoveTestsInserts()
        {
            var rowsToRemove = instance.GetData(a => a.Direccion.Contains("to remove")).ToList();

            foreach (var row in rowsToRemove)
            {
                instance.Remove(new { row.IdCliente });
            }
        }

    }
}
