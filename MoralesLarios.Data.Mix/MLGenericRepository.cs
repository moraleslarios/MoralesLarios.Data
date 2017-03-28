using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MoralesLarios.Data.Dapper;
using MoralesLarios.Data.EntityFramework;
using System.Data.Entity;
using System.Data;

namespace MoralesLarios.Data.Mix
{
    public class MLGenericRepository<TEntity> : IDPGenericRepository<TEntity>, IEFGenericRepository<TEntity>, IMLGenericRepository<TEntity> where TEntity : class
    {
        private readonly IDPGenericRepository<TEntity> dpRepository;
        private readonly IEFGenericRepository<TEntity> efRepository;

        /// <summary>
        /// GenericRepository Dapper + EntitiyFramework
        /// </summary>
        /// <param name="context">DbContext for context</param>
        /// <param name="conn">Connection (if not aggrette connection, it will use the DbContext connection)</param>
        /// <param name="parameterIdentified">Idetenfier parameter (@) to SqlServer (:) to Oracle</param>
        public MLGenericRepository(DbContext context, IDbConnection conn = null, char parameterIdentified = '@')
        {
            efRepository = new EFGenericRepository<TEntity>(context);

            IDbConnection connection = conn ?? context.Database.Connection;

            dpRepository = new DPGenericRepository<TEntity>(connection);
        }

        /// <summary>
        /// GenericRepository Dapper + EntityFramework for Dpendency Injection
        /// </summary>
        /// <param name="dpRepository">dapper GenericRepository</param>
        /// <param name="efRepository">EntityFramework GenericRepository</param>
        public MLGenericRepository(IDPGenericRepository<TEntity> dpRepository, IEFGenericRepository<TEntity> efRepository)
        {
            this.dpRepository = dpRepository;
            this.efRepository = efRepository;
        }

        #region Add-Entity/Async

        /// <summary>
        /// Add a new Entity in DB (EF)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>number changes in DB</returns>
        public int Add(TEntity entity)
        {
            var result = efRepository.Add(entity);

            return result;
        }

        /// <summary>
        /// Add a Sequence of items in BulkInsert (DP)
        /// </summary>
        /// <param name="entities">Sequence of entities</param>
        /// <returns>number changes in DB</returns>
        public int Add(IEnumerable<TEntity> entities)
        {
            var result = dpRepository.Add(entities);

            return result;
        }

        /// <summary>
        /// Add Async a new Entity in DB (EF)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>number changes in DB</returns>
        public Task<int> AddAsync(TEntity entity)
        {
            var result = efRepository.AddAsync(entity);

            return result;
        }

        /// <summary>
        /// Add Async a Sequence of items in BulkInsert (DP)
        /// </summary>
        /// <param name="entities">Sequence of entities</param>
        /// <returns>number changes in DB</returns>
        public Task<int> AddAsync(IEnumerable<TEntity> entities)
        {
            var result = dpRepository.AddAsync(entities);

            return result;
        }

        /// <summary>
        /// Add a sequence of items in DB, returns the new sequence of items from DB (EF)
        /// </summary>
        /// <param name="entities">Sequence of entities</param>
        /// <returns>Items Added with Identity values updated</returns>
        public IEnumerable<TEntity> AddEntities(IEnumerable<TEntity> entities)
        {
            var result = efRepository.AddEntities(entities);

            return result;
        }

        /// <summary>
        /// Add Async a sequence of items in DB, returns the new sequence of items from DB (EF)
        /// </summary>
        /// <param name="entities">Sequence of entities</param>
        /// <returns>Items Added with Identity values updated</returns>
        public Task<IEnumerable<TEntity>> AddEntitiesAsync(IEnumerable<TEntity> entities)
        {
            var result = efRepository.AddEntitiesAsync(entities);

            return result;
        }

        /// <summary>
        ///  Add a new Entity in DB, returns the new entitiy of DB (EF)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Enttiy Added with Identity values updated</returns>
        public TEntity AddEntity(TEntity entity)
        {
            var result = efRepository.AddEntity(entity);

            return result;
        }

        /// <summary>
        ///  Add Async a new Entity in DB, returns the new entitiy of DB (EF)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Enttiy Added with Identity values updated</returns>
        public Task<TEntity> AddEntityAsync(TEntity entity)
        {
            var result = efRepository.AddEntityAsync(entity);

            return result;
        }

        #endregion

        #region All

        /// <summary>
        /// Get all entities (DP)
        /// </summary>
        /// <returns>All entities</returns>
        public IEnumerable<TEntity> All()
        {
            var result = dpRepository.All();

            return result;
        }

        /// <summary>
        /// Get all entities with properties navigation (EF)
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> All(params string[] includes)
        {
            var result = efRepository.All(includes);

            return result;
        }

        /// <summary>
        /// Get Async all entities (DP)
        /// </summary>
        /// <returns>All entities</returns>
        public Task<IEnumerable<TEntity>> AllAsync()
        {
            var result = dpRepository.AllAsync();

            return result;
        }

        /// <summary>
        /// Get async all entities with properties navigation (EF)
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> AllAsync(params string[] includes)
        {
            var result = efRepository.AllAsync(includes);

            return result;
        }

        #endregion

        #region Find/Async

        /// <summary>
        /// Find entity in DB for PK (DP)
        /// </summary>
        /// <param name="pksFields">Object with pk properties</param>
        /// <returns>Entity for pk values</returns>
        public TEntity Find(object pksFields)
        {
            var result = dpRepository.Find(pksFields);

            return result;
        }

        /// <summary>
        /// Find Async entity in DB for PK (DP)
        /// </summary>
        /// <param name="pksFields">Object with pk properties</param>
        /// <returns>Entity for pk values</returns>
        public Task<TEntity> FindAsync(object pksFields)
        {
            return dpRepository.FindAsync(pksFields);
        }


        #endregion

        #region GetData/Async

        /// <summary>
        /// Get Entities in DB from a object filter (equals property with value) (DP)
        /// Example:  new { Name = "Peter", Age = 18 } --> Select * ... Where Name = 'Peter' and Age = 18
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public IEnumerable<TEntity> GetData(object filter)
        {
            var result = dpRepository.GetData(filter);

            return result;
        }

        /// <summary>
        /// Get Entities in DB from qry with object parameters (EF)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public IEnumerable<TEntity> GetData(string qry, object parameters)
        {
            var result = efRepository.GetData(qry, parameters);

            return result;
        }

        /// <summary>
        /// Get Entities in DB from Expression filter (EF)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public IEnumerable<TEntity> GetData(Expression<Func<TEntity, bool>> filter)
        {
            var result = efRepository.GetData(filter);

            return result;
        }

        /// <summary>
        /// Get Entities in DB from Expression filter with includes (EF)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public IEnumerable<TEntity> GetData(Expression<Func<TEntity, bool>> filter, params string[] includes)
        {
            var result = efRepository.GetData(filter, includes);

            return result;
        }

        /// <summary>
        /// Get async Entities in DB from a object filter (equals property with value) (DP)
        /// Example:  new { Name = "Peter", Age = 18 } --> Select * ... Where Name = 'Peter' and Age = 18
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Task with Entities for this filter</returns>
        public Task<IEnumerable<TEntity>> GetDataAsync(object filter)
        {
            return dpRepository.GetDataAsync(filter);
        }

        /// <summary>
        /// Get async Entities in DB from qry with object parameters (EF)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public Task<IEnumerable<TEntity>> GetDataAsync(string qry, object parameters)
        {
            return efRepository.GetDataAsync(qry, parameters);
        }

        /// <summary>
        /// Get async Entities in DB from Expression filter (EF)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public Task<IEnumerable<TEntity>> GetDataAsync(Expression<Func<TEntity, bool>> filter)
        {
            return efRepository.GetDataAsync(filter);
        }

        /// <summary>
        /// Get async Entities in DB from Expression filter with includes (EF)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public Task<IEnumerable<TEntity>> GetDataAsync(Expression<Func<TEntity, bool>> filter, params string[] includes)
        {
            return efRepository.GetDataAsync(filter, includes);
        }

        #endregion

        #region InsertOrUpdate/Async

        public int InstertOrUpdate(TEntity entity, object pks)
        {
            var result = dpRepository.InstertOrUpdate(entity, pks);

            return result;
        }

        public int InstertOrUpdate(TEntity entity)
        {
            var result = efRepository.InstertOrUpdate(entity);

            return result;
        }

        public Task<int> InstertOrUpdateAsync(TEntity entity, object pks)
        {
            return dpRepository.InstertOrUpdateAsync(entity, pks);
        }

        public Task<int> InstertOrUpdateAsync(TEntity entity)
        {
            return efRepository.InstertOrUpdateAsync(entity);
        }

        #endregion

        #region Remove/Async

        /// <summary>
        /// remove a Entity in DB (DP) for PK
        /// </summary>
        /// <param name="key">anonymous type descrive PKs properties</param>
        public void Remove(object key)
        {
            dpRepository.Remove(key);
        }

        /// <summary>
        /// remove Async a Entity in DB (DP) for PK
        /// </summary>
        /// <param name="key">anonymous type descrive PKs properties</param>
        public Task RemoveAsync(object key)
        {
            return dpRepository.RemoveAsync(key);
        }

        /// <summary>
        /// remove a Entity in DB (EF) for Entity
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        public void Remove(TEntity entity)
        {
            efRepository.Remove(entity);
        }

        /// <summary>
        /// remove Async a Entity in DB (EF) for Entity
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        public Task RemoveAsync(TEntity entity)
        {
            return efRepository.RemoveAsync(entity);
        }

        #endregion

        #region Update/Async

        public int Update(TEntity entity, object pks)
        {
            var result = dpRepository.Update(entity, pks);

            return result;
        }

        public int Update(TEntity entity)
        {
            var result = efRepository.Update(entity);

            return result;
        }

        public Task<int> UpdateAsync(TEntity entity, object pks)
        {
            return dpRepository.UpdateAsync(entity, pks);
        }

        #endregion











        public void Dispose()
        {
            throw new NotImplementedException();
        }





    }
}
