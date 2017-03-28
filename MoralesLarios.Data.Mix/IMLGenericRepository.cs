using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoralesLarios.Data.Mix
{
    public interface IMLGenericRepository<TEntity> where TEntity : class
    {
        int Add(IEnumerable<TEntity> entities);
        int Add(TEntity entity);
        Task<int> AddAsync(IEnumerable<TEntity> entities);
        Task<int> AddAsync(TEntity entity);
        IEnumerable<TEntity> AddEntities(IEnumerable<TEntity> entities);
        Task<IEnumerable<TEntity>> AddEntitiesAsync(IEnumerable<TEntity> entities);
        TEntity AddEntity(TEntity entity);
        Task<TEntity> AddEntityAsync(TEntity entity);
        IEnumerable<TEntity> All();
        IEnumerable<TEntity> All(params string[] includes);
        Task<IEnumerable<TEntity>> AllAsync();
        Task<IEnumerable<TEntity>> AllAsync(params string[] includes);
        void Dispose();
        TEntity Find(object pksFields);
        Task<TEntity> FindAsync(object pksFields);
        IEnumerable<TEntity> GetData(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetData(Expression<Func<TEntity, bool>> filter, params string[] includes);
        IEnumerable<TEntity> GetData(object filter);
        IEnumerable<TEntity> GetData(string qry, object parameters);
        Task<IEnumerable<TEntity>> GetDataAsync(Expression<Func<TEntity, bool>> filter);
        Task<IEnumerable<TEntity>> GetDataAsync(Expression<Func<TEntity, bool>> filter, params string[] includes);
        Task<IEnumerable<TEntity>> GetDataAsync(object filter);
        Task<IEnumerable<TEntity>> GetDataAsync(string qry, object parameters);
        int InstertOrUpdate(TEntity entity);
        int InstertOrUpdate(TEntity entity, object pks);
        Task<int> InstertOrUpdateAsync(TEntity entity);
        Task<int> InstertOrUpdateAsync(TEntity entity, object pks);
        void Remove(object key);
        void Remove(TEntity entity);
        Task RemoveAsync(object key);
        Task RemoveAsync(TEntity entity);
        int Update(TEntity entity);
        int Update(TEntity entity, object pks);
        Task<int> UpdateAsync(TEntity entity, object pks);
    }
}