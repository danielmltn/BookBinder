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
    public class AssociateServiceTests
    {

        [TestMethod]
        public void Create()
        {
            var settings = new AssociateDbSettings {CollectionName = "TestCollectionName", ConnectionString = "TestConnectionString", DatabaseName = "TestDatabaseName"};
            var service = new AssociateService(null, settings, new MockMongoClient());
            var inAssociate = new Associate();
            var createdAssociate = service.Create(inAssociate);
            Assert.AreEqual(inAssociate, createdAssociate);
        }
    }
}
