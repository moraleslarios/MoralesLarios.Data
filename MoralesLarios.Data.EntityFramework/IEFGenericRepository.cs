using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoralesLarios.Data.EntityFramework
{
    public interface IEFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> All(params string[] includes);
        Task<IEnumerable<TEntity>> AllAsync(params string[] includes);
        IEnumerable<TEntity> GetData(Expression<Func<TEntity, bool>> filter);
        IEnumerable<TEntity> GetData(Expression<Func<TEntity, bool>> filter, params string[] includes);
        Task<IEnumerable<TEntity>> GetDataAsync(Expression<Func<TEntity, bool>> filter);
        Task<IEnumerable<TEntity>> GetDataAsync(Expression<Func<TEntity, bool>> filter, params string[] includes);
        TEntity AddEntity(TEntity entity);
        Task<TEntity> AddEntityAsync(TEntity entity);
        IEnumerable<TEntity> AddEntities(IEnumerable<TEntity> entities);
        Task<IEnumerable<TEntity>> AddEntitiesAsync(IEnumerable<TEntity> entities);
        int Update(TEntity entity);
        int InstertOrUpdate(TEntity entity);
        Task<int> InstertOrUpdateAsync(TEntity entity);
        void Remove(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}