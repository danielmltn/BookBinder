using MongoDB.Driver;
using System.Collections.Generic;
using Microsoft.Extensions.Logging; 
using AssociateManagement.Models.AssociateInfo;
using AssociateManagement.Models.DBSettings;
//comments here
namespace AssociateManagement.Services
{
    class AssociateService : MongoDbService<Associate>
    {
        public AssociateService(ILogger<AssociateService> logger, IMongoDbSettings settings, MongoClientBase client) : base(logger, settings, client)
        {
            var models = new List<CreateIndexModel<Associate>>();
            models.Add(CreateUniqueField("Email"));
            models.Add(CreateUniqueField("AssociateId"));
            _collection.Indexes.CreateMany(models);
        }

        public override Associate Create(Associate associate)
        {
            try
            {
                _collection.InsertOne(associate);
            } 
            catch (MongoWriteException e) when (e.WriteError.Category.ToString() == "DuplicateKey")
            {
                _logger.LogError(e.Message);
                return null;
            }
            return associate;
        }

    }
}