using MongoDB.Driver;
using System.Collections.Generic;
using Microsoft.Extensions.Logging; 
using BookBinderBE.Models.BookInfo;
using BookBinderBE.Models.DBSettings;
//comments here
namespace BookBinderBE.Services
{
    class BookService : MongoDbService<Book>
    {
        public BookService(ILogger<BookService> logger, IMongoDbSettings settings, MongoClientBase client) : base(logger, settings, client)
        {
            // var models = new List<CreateIndexModel<Book>>();
            // models.Add(CreateUniqueField("Email"));
            // models.Add(CreateUniqueField("BookId"));
            // _collection.Indexes.CreateMany(models);
        }

        public override Book Create(Book Book)
        {
            try
            {
                _collection.InsertOne(Book);
            } 
            catch (MongoWriteException e) when (e.WriteError.Category.ToString() == "DuplicateKey")
            {
                _logger.LogError(e.Message);
                return null;
            }
            return Book;
        }

        public override Book Get(string id)
        {
            return _collection.Find(Book => Book.Id == id).FirstOrDefault();
        }

        public override void Update(string id, Book bookIn)
        {
            _collection.ReplaceOne(book => book.Id == id, bookIn);
        }

    }
}