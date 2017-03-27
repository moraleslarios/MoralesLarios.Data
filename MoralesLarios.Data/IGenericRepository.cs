using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoralesLarios.Data
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> All();
        Task<IEnumerable<TEntity>> AllAsync();
        IEnumerable<TEntity> GetData(string qry, object parameters);
        Task<IEnumerable<TEntity>> GetDataAsync(string qry, object parameters);
        TEntity Find(object pksFields);
        Task<TEntity> FindAsync(object pksFields);
        int Add(TEntity entity);
        Task<int> AddAsync(TEntity entity);
        int Add(IEnumerable<TEntity> entities);
        Task<int> AddAsync(IEnumerable<TEntity> entities);
        void Remove(object key);
        Task RemoveAsync(object key);
        int Update(TEntity entity, object pks);
        Task<int> UpdateAsync(TEntity entity, object pks);
        int InstertOrUpdate(TEntity entity, object pks);
        Task<int> InstertOrUpdateAsync(TEntity entity, object pks);
    }
}
