using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using AssociateManagement.Models.Organization;

namespace AssociateManagement.Models.AssociateInfo
{
    public class Associate
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string AssociateId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }

        public OrgInfo OrgInfo { get; set; }

    }
}