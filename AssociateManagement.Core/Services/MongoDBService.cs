
using MongoDB.Driver;
using System.Collections.Generic;
using Microsoft.Extensions.Logging; 
using AssociateManagement.Models.DBSettings;

namespace AssociateManagement.Services
{
    abstract class MongoDbService<T> : IDatabaseService<T>
    {
        protected readonly ILogger _logger;
        protected readonly IMongoCollection<T> _collection;

        public MongoDbService(ILogger logger, IMongoDbSettings settings, MongoClientBase client)
        {
            _logger = logger;

            // var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<T>(settings.CollectionName);
        }

        public virtual T Create(T document)
        {
            _collection.InsertOne(document);
            return document;
        }
        

        public virtual List<T> Get()
        {
            return _collection.Find(document => true).ToList();
        }

        protected static CreateIndexModel<T> CreateUniqueField(string fieldName)
        {
            var options = new CreateIndexOptions() { Unique = true };
            var field = new StringFieldDefinition<T>(fieldName);
            var indexDefinition = new IndexKeysDefinitionBuilder<T>().Ascending(field);
            var indexModel = new CreateIndexModel<T>(indexDefinition, options);
            return indexModel;
        }

    }
}