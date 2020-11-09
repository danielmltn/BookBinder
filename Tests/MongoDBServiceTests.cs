using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using BookBinderBE.Models.DBSettings;
using BookBinderBE.Models.BookInfo;
using BookBinderBE.Services;
using MongoDB.Driver;
using MongoDB.Driver.Core.Clusters;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace BookBinderBE.Tests
{
    [TestClass]
    public class MongoDBServiceTests
    {

        class MockMongoDBService<Book> : MongoDbService<Book>
        {
            public MockMongoDBService(ILogger<MockMongoDBService<Book>> logger, IMongoDbSettings settings, MongoClientBase client) : base(logger, settings, client)
            {
                
            }
            public override Book Get(string id)
            {
                return default(Book);
            }
            public static new CreateIndexModel<Book> CreateUniqueField(string fieldName)
            {
                return MongoDbService<Book>.CreateUniqueField(fieldName);
            }

            public override void Update(string id, Book bookIn)
            {
            }
        }

        [TestMethod]
        public void CreateUniqueField()
        {
            var indexModel = MockMongoDBService<Book>.CreateUniqueField("test");
            bool? isUnique = indexModel.Options.Unique;
            Assert.IsTrue(isUnique.GetValueOrDefault(false));
            
        }
    }
}
