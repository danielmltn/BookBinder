using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using AssociateManagement.Models.DBSettings;
using AssociateManagement.Models.AssociateInfo;
using AssociateManagement.Services;
using MongoDB.Driver;
using MongoDB.Driver.Core.Clusters;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace AssociateManagement.Tests
{
    [TestClass]
    public class MongoDBServiceTests
    {

        class MockMongoDBService<Associate> : MongoDbService<Associate>
        {
            public MockMongoDBService(ILogger<MockMongoDBService<Associate>> logger, IMongoDbSettings settings, MongoClientBase client) : base(logger, settings, client)
            {
                
            }
            public static new CreateIndexModel<Associate> CreateUniqueField(string fieldName)
            {
                return MongoDbService<Associate>.CreateUniqueField(fieldName);
            }
        }

        [TestMethod]
        public void CreateUniqueField()
        {
            var indexModel = MockMongoDBService<Associate>.CreateUniqueField("test");
            bool? isUnique = indexModel.Options.Unique;
            Assert.IsTrue(isUnique.GetValueOrDefault(false));
            
        }
    }
}
