using Catalog.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Catalog.Repositories
{
    public class MongoDBItemsRepository : IItemsRepository
    {
        #region properties
        private const string databaseName = "Catalog";
        private const string collectionName = "items";

        private readonly IMongoCollection<Item> _itemsCollection;
        private readonly FilterDefinitionBuilder<Item> filterBuilder = Builders<Item>.Filter;
        #endregion

        #region Constructor
        public MongoDBItemsRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            _itemsCollection = database.GetCollection<Item>(collectionName);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Creation of item in DBB
        /// </summary>
        /// <param name="item"></param>
        public void CreateItem(Item item)
        {
            _itemsCollection.InsertOne(item);
        }

        public void DeleteItem(Guid id)
        {
            var filter = filterBuilder.Eq(item => item.Id, id);
            _itemsCollection.DeleteOne(filter);
        }

        public Item GetItem(Guid id)
        {
            var filter = filterBuilder.Eq(item => item.Id, id);
            return _itemsCollection.Find(filter).SingleOrDefault();
        }

        public IEnumerable<Item> GetItems()
        {
            return _itemsCollection.Find(new BsonDocument()).ToList();
        }

        public void UpdateItem(Item item)
        {
            var filter = filterBuilder.Eq(existingItem => existingItem.Id, item.Id);
            _itemsCollection.ReplaceOne(filter, item);
        }
        #endregion
    }
}
