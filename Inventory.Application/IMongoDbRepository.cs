using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application
{
    public interface IMongoDbRepository
    {
        Task<long> GetIdAsync<TEntity>(long id) where TEntity: class ;

        Task<TEntity> GetAsync<TEntity>(TEntity entity) where TEntity: class ;

        Task<long> CreateAsync<TEntity>(TEntity entity) where TEntity : class ;

        Task<long> DeleteAsync<TEntity>(long id) where TEntity: class ;

        Task<long> UpdateAsync<TEntity>(TEntity entity) where TEntity: class ;  
    }
}

