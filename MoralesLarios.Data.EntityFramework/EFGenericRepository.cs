using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MoralesLarios.Data.EntityFramework;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using MoralesLarios.Data.Helper;
using MoralesLarios.Data.EntityFramework.Infrastructure;

namespace MoralesLarios.Data.EntityFramework
{
    public class EFGenericRepository<TEntity> : IEFGenericRepository<TEntity> where TEntity : class
    {

        private readonly DbContext context;


        private readonly IIncludeInjector<TEntity> includeInjector;
        private readonly IPKExtractor              pkExtractor;
        private readonly IQryParametersManager     qryParameterManager;


        public EFGenericRepository(DbContext context)
        {
            includeInjector     = new IncludeInjector<TEntity>();
            pkExtractor         = new PKExtractor();
            qryParameterManager = new QryParametersManager();

            if (context == null) throw new ArgumentNullException(nameof(context), $"The argument {nameof(context)} is not null");

            this.context = context;
        }



        #region All/Async

        /// <summary>
        /// Get all entities with properties navigation
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> All(params string[] includes)
        {
            DbQuery<TEntity> dbQry = context.Set<TEntity>();

            dbQry = includeInjector.InjectorIncludes(dbQry, includes);

            var result = dbQry.AsNoTracking().ToList();

            return result;
        }

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> All() => All();


        /// <summary>
        /// Get async all entities with properties navigation
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> AllAsync(params string[] includes)
        {
            return Task.Run(() =>
            {
                return All(includes);
            });
        }

        /// <summary>
        /// Get async all entities
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        public Task<IEnumerable<TEntity>> AllAsync() => AllAsync();


        #endregion

        #region GetData/Async

        /// <summary>
        /// Get Entities in DB from Expression filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public IEnumerable<TEntity> GetData(Expression<Func<TEntity, bool>> filter)
        {
            ParameterValidator.ValidateObject(filter, nameof(filter));

            DbQuery<TEntity> dbQry = context.Set<TEntity>();

            var result = dbQry.AsNoTracking().Where(filter).ToList();

            return result;
        }

        /// <summary>
        /// Get Entities in DB from Expression filter with includes
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public IEnumerable<TEntity> GetData(Expression<Func<TEntity, bool>> filter, params string[] includes)
        {
            ParameterValidator.ValidateObject(filter, nameof(filter));

            DbQuery<TEntity> dbQry = context.Set<TEntity>();

            dbQry = includeInjector.InjectorIncludes(dbQry, includes);

            var result = dbQry.AsNoTracking().Where(filter).ToList();

            return result;
        }

        /// <summary>
        /// Get async Entities in DB from Expression filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public Task<IEnumerable<TEntity>> GetDataAsync(Expression<Func<TEntity, bool>> filter)
        {
            return Task.Run(() =>
            {
                return GetData(filter);
            });
        }

        /// <summary>
        /// Get async Entities in DB from Expression filter with includes (EF)
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public Task<IEnumerable<TEntity>> GetDataAsync(Expression<Func<TEntity, bool>> filter, params string[] includes)
        {
            return Task.Run(() =>
            {
                return GetData(filter, includes);
            });
        }


        /// <summary>
        /// Get Entities in DB from qry with object parameters
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public IEnumerable<TEntity> GetData(string qry, object parameters)
        {
            ParameterValidator.ValidateString(qry, nameof(qry));
            ParameterValidator.ValidateObject(parameters, nameof(parameters));

            var parametersDictionary = qryParameterManager.GetParametersDictionary(parameters);
            string qryDef = qryParameterManager.GenerateStringQry(qry, parametersDictionary);

            var result = context.Database.SqlQuery<TEntity>(qryDef).ToList();

            return result;
        }

        /// <summary>
        /// Get async Entities in DB from qry with object parameters
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>Entities for this filter</returns>
        public Task<IEnumerable<TEntity>> GetDataAsync(string qry, object parameters)
        {
            return Task.Run(() =>
            {
                return GetData(qry, parameters);
            });
        }

        #endregion

        #region Find/Async

        /// <summary>
        /// Find entity in DB for PK
        /// </summary>
        /// <param name="pksFields">Object with pk properties</param>
        /// <returns>Entity for pk values</returns>
        public TEntity Find(object pksFields)
        {
            ParameterValidator.ValidateObject(pksFields, nameof(pksFields));

            var parametersPk = qryParameterManager.GetParametersDictionary(pksFields).Select(a => a.Value).ToArray();

            DbSet<TEntity> dbSet = context.Set<TEntity>();

            var result = dbSet.Find(parametersPk);

            return result;
        }

        /// <summary>
        /// Find Async entity in DB for PK
        /// </summary>
        /// <param name="pksFields">Object with pk properties</param>
        /// <returns>Entity for pk values</returns>
        public Task<TEntity> FindAsync(object pksFields)
        {
            return Task.Run(() => Find(pksFields));
        }

        #endregion

        #region Add/Async

        /// <summary>
        ///  Add a new Entity in DB, returns the new entitiy of DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Enttiy Added with Identity values updated</returns>
        public TEntity AddEntity(TEntity entity)
        {
            ParameterValidator.ValidateObject(entity, nameof(entity));

            DbSet<TEntity> dbSet = context.Set<TEntity>();

            dbSet.Add(entity);

            context.SaveChanges();

            var result = (TEntity)context.Entry(entity).GetDatabaseValues().ToObject();

            return result;
        }

        /// <summary>
        ///  Add Async a new Entity in DB, returns the new entitiy from DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Enttiy Added with Identity values updated</returns>
        public Task<TEntity> AddEntityAsync(TEntity entity)
        {
            return Task.Run(() =>
            {
                return AddEntity(entity);
            });
        }

        /// <summary>
        /// Add a new Entity in DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>number changes in DB</returns>
        public int Add(TEntity entity)
        {
            ParameterValidator.ValidateObject(entity, nameof(entity));

            DbSet<TEntity> dbSet = context.Set<TEntity>();

            dbSet.Add(entity);

            var result = context.SaveChanges();

            return result;
        }

        /// <summary>
        /// Add Async a new Entity in DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>number changes in DB</returns>
        public Task<int> AddAsync(TEntity entity)
        {
            return Task.Run(() =>
            {
                return Add(entity);
            });
        }

        /// <summary>
        /// Add a Sequence of items
        /// </summary>
        /// <param name="entities">Sequence of entities</param>
        /// <returns>number changes in DB</returns>
        public int Add(IEnumerable<TEntity> entities)
        {
            ParameterValidator.ValidateObject(entities, nameof(entities));

            DbSet<TEntity> dbSet = context.Set<TEntity>();

            dbSet.AddRange(entities);

            var result = context.SaveChanges();

            return result;
        }

        /// <summary>
        /// Add Async a Sequence of items
        /// </summary>
        /// <param name="entities">Sequence of entities</param>
        /// <returns>number changes in DB</returns>
        public Task<int> AddAsync(IEnumerable<TEntity> entities)
        {
            return Task.Run(() =>
            {
                return Add(entities);
            });
        }

        /// <summary>
        ///  Add a sequence of items in DB, returns the new sequence of items from DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Items Added with Identity values updated</returns>
        public IEnumerable<TEntity> AddEntities(IEnumerable<TEntity> entities)
        {
            ParameterValidator.ValidateObject(entities, nameof(entities));

            DbSet<TEntity> dbSet = context.Set<TEntity>();

            dbSet.AddRange(entities);

            context.SaveChanges();

            foreach (var entity in entities)
            {
                var result = (TEntity)context.Entry(entity).GetDatabaseValues().ToObject();

                yield return result;
            }
        }

        /// <summary>
        ///  Add async a sequence of items in DB, returns the new sequence of items from DB
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Items Added with Identity values updated</returns>
        public Task<IEnumerable<TEntity>> AddEntitiesAsync(IEnumerable<TEntity> entities)
        {
            return Task.Run(() =>
            {
                return AddEntities(entities);
            });
        }


        #endregion

        #region Remove/Async

        /// <summary>
        /// remove a Entity in DB for PK
        /// </summary>
        /// <param name="key">anonymous type descrive PKs properties</param>
        public void Remove(object key)
        {
            ParameterValidator.ValidateObject(key, nameof(key));

            DbSet<TEntity> dbSet = context.Set<TEntity>();

            var pkFields = pkExtractor.ExtractPKInObjectEnumerable(key).ToArray();

            var entity = dbSet.Find(pkFields);

            if (entity != null)
            {
                dbSet.Remove(entity);
            }

            context.SaveChanges();
        }

        /// <summary>
        /// remove Async a Entity in DB for PK
        /// </summary>
        /// <param name="key">anonymous type descrive PKs properties</param>
        public Task RemoveAsync(object key)
        {
            return Task.Run(() =>
            {
                Remove(key);
            });
        }

        /// <summary>
        /// remove a Entity in DB for Entity
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        public void Remove(TEntity entity)
        {
            ParameterValidator.ValidateObject(entity, nameof(entity));

            var entry = context.Entry(entity);

            entry.State = EntityState.Deleted;

            context.SaveChanges();
        }

        /// <summary>
        /// remove Async a Entity in DB for Entity
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        public Task RemoveAsync(TEntity entity)
        {
            return Task.Run(() => Remove(entity));
        }

        #endregion

        #region Update/Async

        public int Update(TEntity entity)
        {
            ParameterValidator.ValidateObject(entity, nameof(entity));

            var entry = context.Entry<TEntity>(entity);

            entry.State = EntityState.Modified;

            var result = context.SaveChanges();

            return result;
        }

        public int Update(TEntity entity, object pks)
        {
            ParameterValidator.ValidateObject(entity, nameof(entity));

            var entry = context.Entry<TEntity>(entity);

            entry.State = EntityState.Modified;

            var result = context.SaveChanges();

            return result;
        }

        public Task<int> UpdateAsync(TEntity entity)
        {
            return Task.Run(() =>
            {
                return Update(entity);
            });
        }

        public Task<int> UpdateAsync(TEntity entity, object pks)
        {
            return Task.Run(() =>
            {
                return Update(entity);
            });
        }


        #endregion

        #region InsertOrUpdate/Async

        public int InstertOrUpdate(TEntity entity)
        {
            ParameterValidator.ValidateObject(entity, nameof(entity));

            var entry = context.Entry<TEntity>(entity);

            entry.State = EntityState.Modified;

            var result = TrySaveChanges(entity);

            return result;
        }



        public Task<int> InstertOrUpdateAsync(TEntity entity)
        {
            return Task.Run(() =>
            {
                return InstertOrUpdate(entity);
            });
        }

        public int InstertOrUpdate(TEntity entity, object pks)
        {
            ParameterValidator.ValidateObject(entity, nameof(entity));

            var entry = context.Entry<TEntity>(entity);

            entry.State = EntityState.Modified;

            var result = TrySaveChanges(entity);

            return result;
        }


        public Task<int> InstertOrUpdateAsync(TEntity entity, object pks)
        {
            return Task.Run(() =>
            {
                return InstertOrUpdate(entity);
            });
        }


        #endregion


        private int TrySaveChanges(TEntity entity)
        {
            int result = 0;

            try
            {
                result = context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = context.Entry<TEntity>(entity);

                entry.State = EntityState.Added;

                result = context.SaveChanges();
            }

            return result;

        }



        public void Dispose()
        {

        }


    }
}
