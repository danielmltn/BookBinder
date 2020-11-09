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
    public class BookServiceTests
    {

        [TestMethod]
        public void Create()
        {
            var settings = new BookDbSettings {CollectionName = "TestCollectionName", ConnectionString = "TestConnectionString", DatabaseName = "TestDatabaseName"};
            var service = new BookService(null, settings, new MockMongoClient());
            var inBook = new Book();
            var createdBook = service.Create(inBook);
            Assert.AreEqual(inBook, createdBook);
        }
    }
}
