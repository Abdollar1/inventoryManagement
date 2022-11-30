using Inventory.Application.Interface;
using Inventory.Application.ItemDtos;
using Inventory.Domain; 
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Repository
{
    public class MongoDbItemRepository : IItemsRpository
    {

        private const string databaseName = "firstApi";
        private const string collectionName = "items";
        private readonly IMongoCollection<Item> itemsCollection;


        public MongoDbItemRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            itemsCollection = database.GetCollection<Item>(collectionName);

        }
        public void createItem(Item item)
        {
            itemsCollection.InsertOne(item);
        }

        public void deleteItem(Guid id)
        {
            
            itemsCollection.DeleteOne( ID => ID.id == id);
             
        }

        public async Task<Item> GetItem(Guid id)
        {
            return (Item)await itemsCollection.FindAsync(ID => ID.id == id);
             
        }

        public IEnumerable<Item> GetItems()
        {
            return itemsCollection.Find(new BsonDocument()).ToList();

        }

        public void updateItem(Item item)
        {
            var findItem = itemsCollection.Find( ID => ID.id == item.id);
            if (findItem == null) {

                return n;
            }
            itemsCollection.InsertOne(item);
        }
    }
}
