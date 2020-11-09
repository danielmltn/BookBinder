using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using BookBinderBE.Models.Organization;

namespace BookBinderBE.Models.BookInfo
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string[] Categories { get; set; }
        public string[] Quotes { get; set; }
        public int pages { get; set; }

        // public OrgInfo OrgInfo { get; set; }

    }
}