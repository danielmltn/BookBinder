using Microsoft.Extensions.Logging;
using BookBinderBE.Models.DBSettings;
using BookBinderBE.Models.BookInfo;
using BookBinderBE.Services;
using MongoDB.Driver;
using MongoDB.Driver.Core.Clusters;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

public class MockMongoIndexManager<Book> : IMongoIndexManager<Book>
{
    public MongoCollectionSettings Settings { get => null; }
    public CollectionNamespace CollectionNamespace { get => null; }
    public IBsonSerializer<Book> DocumentSerializer { get; }
    public IEnumerable<string> CreateMany(IEnumerable<CreateIndexModel<Book>> models, CancellationToken cancellationToken = default) 
    {
        return new List<string>{"test"};
    }
    public IEnumerable<string> CreateMany(IEnumerable<CreateIndexModel<Book>> models, CreateManyIndexesOptions options, CancellationToken cancellationToken = default)
    {
        return new List<string>{"test"};
    }
    public IEnumerable<string> CreateMany(IClientSessionHandle session, IEnumerable<CreateIndexModel<Book>> models, CreateManyIndexesOptions options, CancellationToken cancellationToken = default)
    {
        return new List<string>{"test"};
    }
    public IEnumerable<string> CreateMany(IClientSessionHandle session, IEnumerable<CreateIndexModel<Book>> models, CancellationToken cancellationToken = default)
    {
        return new List<string>{"test"};
    }
    public Task<IEnumerable<string>> CreateManyAsync(IEnumerable<CreateIndexModel<Book>> models, CancellationToken cancellationToken = default) => null;
    public Task<IEnumerable<string>> CreateManyAsync(IEnumerable<CreateIndexModel<Book>> models, CreateManyIndexesOptions options, CancellationToken cancellationToken = default) => null;
    public Task<IEnumerable<string>> CreateManyAsync(IClientSessionHandle session, IEnumerable<CreateIndexModel<Book>> models, CancellationToken cancellationToken = default) => null;
    public Task<IEnumerable<string>> CreateManyAsync(IClientSessionHandle session, IEnumerable<CreateIndexModel<Book>> models, CreateManyIndexesOptions options, CancellationToken cancellationToken = default) => null;
    public string CreateOne(CreateIndexModel<Book> model, CreateOneIndexOptions options = null, CancellationToken cancellationToken = default) => "index name here";
    public string CreateOne(IndexKeysDefinition<Book> keys, CreateIndexOptions options = null, CancellationToken cancellationToken = default) => "";
    public string CreateOne(IClientSessionHandle session, IndexKeysDefinition<Book> keys, CreateIndexOptions options = null, CancellationToken cancellationToken = default) => "";
    public string CreateOne(IClientSessionHandle session, CreateIndexModel<Book> model, CreateOneIndexOptions options = null, CancellationToken cancellationToken = default) => "";
    public Task<string> CreateOneAsync(CreateIndexModel<Book> model, CreateOneIndexOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<string> CreateOneAsync(IndexKeysDefinition<Book> keys, CreateIndexOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<string> CreateOneAsync(IClientSessionHandle session, IndexKeysDefinition<Book> keys, CreateIndexOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<string> CreateOneAsync(IClientSessionHandle session, CreateIndexModel<Book> model, CreateOneIndexOptions options = null, CancellationToken cancellationToken = default) => null;
    public void DropAll(IClientSessionHandle session, DropIndexOptions options, CancellationToken cancellationToken = default) {}
    public void DropAll(CancellationToken cancellationToken = default) {}
    public void DropAll(DropIndexOptions options, CancellationToken cancellationToken = default) {}
    public void DropAll(IClientSessionHandle session, CancellationToken cancellationToken = default) {}
    public Task DropAllAsync(DropIndexOptions options, CancellationToken cancellationToken = default) => null;
    public Task DropAllAsync(CancellationToken cancellationToken = default) => null;
    public Task DropAllAsync(IClientSessionHandle session, DropIndexOptions options, CancellationToken cancellationToken = default) => null;
    public Task DropAllAsync(IClientSessionHandle session, CancellationToken cancellationToken = default) => null;
    public void DropOne(string name, DropIndexOptions options, CancellationToken cancellationToken = default) {}
    public void DropOne(IClientSessionHandle session, string name, CancellationToken cancellationToken = default) {}
    public void DropOne(IClientSessionHandle session, string name, DropIndexOptions options, CancellationToken cancellationToken = default) {}
    public void DropOne(string name, CancellationToken cancellationToken = default) {}
    public Task DropOneAsync(string name, CancellationToken cancellationToken = default) => null;
    public Task DropOneAsync(IClientSessionHandle session, string name, CancellationToken cancellationToken = default) => null;
    public Task DropOneAsync(IClientSessionHandle session, string name, DropIndexOptions options, CancellationToken cancellationToken = default) => null;
    public Task DropOneAsync(string name, DropIndexOptions options, CancellationToken cancellationToken = default) => null;
    public IAsyncCursor<BsonDocument> List(CancellationToken cancellationToken = default) => null;
    public IAsyncCursor<BsonDocument> List(IClientSessionHandle session, CancellationToken cancellationToken = default) => null;
    public Task<IAsyncCursor<BsonDocument>> ListAsync(CancellationToken cancellationToken = default) => null;
    public Task<IAsyncCursor<BsonDocument>> ListAsync(IClientSessionHandle session, CancellationToken cancellationToken = default) => null;

}

public class MockMongoCollection<Book> : MongoCollectionBase<Book>
{
    public override void InsertOne(Book document, InsertOneOptions options = null, CancellationToken cancellationToken = default) {}
    public override MongoCollectionSettings Settings { get => null; }
    public override IBsonSerializer<Book> DocumentSerializer { get => null; }
    public override IMongoDatabase Database { get => null; }
    public override CollectionNamespace CollectionNamespace { get => null; }
    public override IMongoIndexManager<Book> Indexes { get => new MockMongoIndexManager<Book>(); }
    public override Task<IAsyncCursor<TResult>> AggregateAsync<TResult>(PipelineDefinition<Book, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) => null;
    public override Task<BulkWriteResult<Book>> BulkWriteAsync(IEnumerable<WriteModel<Book>> requests, BulkWriteOptions options = null, CancellationToken cancellationToken = default) => null;
    public override Task<IAsyncCursor<TField>> DistinctAsync<TField>(FieldDefinition<Book, TField> field, FilterDefinition<Book> filter, DistinctOptions options = null, CancellationToken cancellationToken = default) => null;
    public override Task<IAsyncCursor<TProjection>> FindAsync<TProjection>(FilterDefinition<Book> filter, FindOptions<Book, TProjection> options = null, CancellationToken cancellationToken = default) => null;
    public override Task<TProjection> FindOneAndDeleteAsync<TProjection>(FilterDefinition<Book> filter, FindOneAndDeleteOptions<Book, TProjection> options = null, CancellationToken cancellationToken = default) => null;
    public override Task<TProjection> FindOneAndReplaceAsync<TProjection>(FilterDefinition<Book> filter, Book replacement, FindOneAndReplaceOptions<Book, TProjection> options = null, CancellationToken cancellationToken = default) => null;
    public override Task<TProjection> FindOneAndUpdateAsync<TProjection>(FilterDefinition<Book> filter, UpdateDefinition<Book> update, FindOneAndUpdateOptions<Book, TProjection> options = null, CancellationToken cancellationToken = default) => null;
    public override Task<IAsyncCursor<TResult>> MapReduceAsync<TResult>(BsonJavaScript map, BsonJavaScript reduce, MapReduceOptions<Book, TResult> options = null, CancellationToken cancellationToken = default) => null;
    public override IMongoCollection<Book> WithReadPreference(ReadPreference readPreference) => null;
    public override IMongoCollection<Book> WithWriteConcern(WriteConcern writeConcern) => null;
    public override IFilteredMongoCollection<TDerivedDocument> OfType<TDerivedDocument>() => null;
    [Obsolete]
    public override Task<long> CountAsync(FilterDefinition<Book> filter, CountOptions options = null, CancellationToken cancellationToken = default) => null;





}

public class MockMongoDatabase : IMongoDatabase
{
    public IMongoCollection<Book> GetCollection<Book>(string name, MongoCollectionSettings settings = null)
    {
        return new MockMongoCollection<Book>();
    }
    public MongoDatabaseSettings Settings { get => null; }
    public IMongoClient Client { get => null; }
    public DatabaseNamespace DatabaseNamespace { get => null; }
    public IAsyncCursor<TResult> Aggregate<TResult>(PipelineDefinition<NoPipelineInput, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) => null;
    public IAsyncCursor<TResult> Aggregate<TResult>(IClientSessionHandle session, PipelineDefinition<NoPipelineInput, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<IAsyncCursor<TResult>> AggregateAsync<TResult>(PipelineDefinition<NoPipelineInput, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<IAsyncCursor<TResult>> AggregateAsync<TResult>(IClientSessionHandle session, PipelineDefinition<NoPipelineInput, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) => null;
    public void AggregateToCollection<TResult>(PipelineDefinition<NoPipelineInput, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) {}
    public void AggregateToCollection<TResult>(IClientSessionHandle session, PipelineDefinition<NoPipelineInput, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) {}
    public Task AggregateToCollectionAsync<TResult>(PipelineDefinition<NoPipelineInput, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task AggregateToCollectionAsync<TResult>(IClientSessionHandle session, PipelineDefinition<NoPipelineInput, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) => null;
    public void CreateCollection(string name, CreateCollectionOptions options = null, CancellationToken cancellationToken = default) {}
    public void CreateCollection(IClientSessionHandle session, string name, CreateCollectionOptions options = null, CancellationToken cancellationToken = default) {}
    public Task CreateCollectionAsync(string name, CreateCollectionOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task CreateCollectionAsync(IClientSessionHandle session, string name, CreateCollectionOptions options = null, CancellationToken cancellationToken = default) => null;
    public void CreateView<Book, TResult>(string viewName, string viewOn, PipelineDefinition<Book, TResult> pipeline, CreateViewOptions<Book> options = null, CancellationToken cancellationToken = default) {}
    public void CreateView<Book, TResult>(IClientSessionHandle session, string viewName, string viewOn, PipelineDefinition<Book, TResult> pipeline, CreateViewOptions<Book> options = null, CancellationToken cancellationToken = default) {}
    public Task CreateViewAsync<Book, TResult>(string viewName, string viewOn, PipelineDefinition<Book, TResult> pipeline, CreateViewOptions<Book> options = null, CancellationToken cancellationToken = default) => null;
    public Task CreateViewAsync<Book, TResult>(IClientSessionHandle session, string viewName, string viewOn, PipelineDefinition<Book, TResult> pipeline, CreateViewOptions<Book> options = null, CancellationToken cancellationToken = default) => null;
    public void DropCollection(IClientSessionHandle session, string name, CancellationToken cancellationToken = default) {}
    public void DropCollection(string name, CancellationToken cancellationToken = default) {}
    public Task DropCollectionAsync(string name, CancellationToken cancellationToken = default) => null;
    public Task DropCollectionAsync(IClientSessionHandle session, string name, CancellationToken cancellationToken = default) => null;
    public IAsyncCursor<string> ListCollectionNames(ListCollectionNamesOptions options = null, CancellationToken cancellationToken = default) => null;
    public IAsyncCursor<string> ListCollectionNames(IClientSessionHandle session, ListCollectionNamesOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<IAsyncCursor<string>> ListCollectionNamesAsync(ListCollectionNamesOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<IAsyncCursor<string>> ListCollectionNamesAsync(IClientSessionHandle session, ListCollectionNamesOptions options = null, CancellationToken cancellationToken = default) => null;
    public IAsyncCursor<BsonDocument> ListCollections(ListCollectionsOptions options = null, CancellationToken cancellationToken = default) => null;
    public IAsyncCursor<BsonDocument> ListCollections(IClientSessionHandle session, ListCollectionsOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<IAsyncCursor<BsonDocument>> ListCollectionsAsync(ListCollectionsOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<IAsyncCursor<BsonDocument>> ListCollectionsAsync(IClientSessionHandle session, ListCollectionsOptions options = null, CancellationToken cancellationToken = default) => null;
    public void RenameCollection(string oldName, string newName, RenameCollectionOptions options = null, CancellationToken cancellationToken = default) {}
    public void RenameCollection(IClientSessionHandle session, string oldName, string newName, RenameCollectionOptions options = null, CancellationToken cancellationToken = default) {}
    public Task RenameCollectionAsync(string oldName, string newName, RenameCollectionOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task RenameCollectionAsync(IClientSessionHandle session, string oldName, string newName, RenameCollectionOptions options = null, CancellationToken cancellationToken = default) => null;
    public TResult RunCommand<TResult>(Command<TResult> command, ReadPreference readPreference = null, CancellationToken cancellationToken = default) => default(TResult);
    public TResult RunCommand<TResult>(IClientSessionHandle session, Command<TResult> command, ReadPreference readPreference = null, CancellationToken cancellationToken = default) => default(TResult);
    public Task<TResult> RunCommandAsync<TResult>(Command<TResult> command, ReadPreference readPreference = null, CancellationToken cancellationToken = default) => null;
    public Task<TResult> RunCommandAsync<TResult>(IClientSessionHandle session, Command<TResult> command, ReadPreference readPreference = null, CancellationToken cancellationToken = default) => null;
    public IChangeStreamCursor<TResult> Watch<TResult>(PipelineDefinition<ChangeStreamDocument<BsonDocument>, TResult> pipeline, ChangeStreamOptions options = null, CancellationToken cancellationToken = default) => null;
    public IChangeStreamCursor<TResult> Watch<TResult>(IClientSessionHandle session, PipelineDefinition<ChangeStreamDocument<BsonDocument>, TResult> pipeline, ChangeStreamOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<IChangeStreamCursor<TResult>> WatchAsync<TResult>(PipelineDefinition<ChangeStreamDocument<BsonDocument>, TResult> pipeline, ChangeStreamOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<IChangeStreamCursor<TResult>> WatchAsync<TResult>(IClientSessionHandle session, PipelineDefinition<ChangeStreamDocument<BsonDocument>, TResult> pipeline, ChangeStreamOptions options = null, CancellationToken cancellationToken = default) => null;
    public IMongoDatabase WithReadConcern(ReadConcern readConcern) => null;
    public IMongoDatabase WithReadPreference(ReadPreference readPreference) => null;
    public IMongoDatabase WithWriteConcern(WriteConcern writeConcern) => null;

}

public class MockMongoClient : MongoClientBase
{
    public override IMongoDatabase GetDatabase(string name, MongoDatabaseSettings settings = null)
    {
        return new MockMongoDatabase();
    }

    public override MongoClientSettings Settings { get => null; }
    public override ICluster Cluster { get => null; }
    public override Task<IAsyncCursor<BsonDocument>> ListDatabasesAsync(CancellationToken cancellationToken = default) => null;
    public override Task DropDatabaseAsync(string name, CancellationToken cancellationToken = default) => null;
    
}