using Inventory.Application;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure
{
    public class MongoDbRepository : IMongoDbRepository
    {
        public Task<long> CreateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<long> DeleteAsync<TEntity>(long id) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<long> GetIdAsync<TEntity>(long id) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<long> UpdateAsync<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
