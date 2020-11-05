using Microsoft.Extensions.Logging;
using AssociateManagement.Models.DBSettings;
using AssociateManagement.Models.AssociateInfo;
using AssociateManagement.Services;
using MongoDB.Driver;
using MongoDB.Driver.Core.Clusters;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

public class MockMongoIndexManager<Associate> : IMongoIndexManager<Associate>
{
    public MongoCollectionSettings Settings { get => null; }
    public CollectionNamespace CollectionNamespace { get => null; }
    public IBsonSerializer<Associate> DocumentSerializer { get; }
    public IEnumerable<string> CreateMany(IEnumerable<CreateIndexModel<Associate>> models, CancellationToken cancellationToken = default) 
    {
        return new List<string>{"test"};
    }
    public IEnumerable<string> CreateMany(IEnumerable<CreateIndexModel<Associate>> models, CreateManyIndexesOptions options, CancellationToken cancellationToken = default)
    {
        return new List<string>{"test"};
    }
    public IEnumerable<string> CreateMany(IClientSessionHandle session, IEnumerable<CreateIndexModel<Associate>> models, CreateManyIndexesOptions options, CancellationToken cancellationToken = default)
    {
        return new List<string>{"test"};
    }
    public IEnumerable<string> CreateMany(IClientSessionHandle session, IEnumerable<CreateIndexModel<Associate>> models, CancellationToken cancellationToken = default)
    {
        return new List<string>{"test"};
    }
    public Task<IEnumerable<string>> CreateManyAsync(IEnumerable<CreateIndexModel<Associate>> models, CancellationToken cancellationToken = default) => null;
    public Task<IEnumerable<string>> CreateManyAsync(IEnumerable<CreateIndexModel<Associate>> models, CreateManyIndexesOptions options, CancellationToken cancellationToken = default) => null;
    public Task<IEnumerable<string>> CreateManyAsync(IClientSessionHandle session, IEnumerable<CreateIndexModel<Associate>> models, CancellationToken cancellationToken = default) => null;
    public Task<IEnumerable<string>> CreateManyAsync(IClientSessionHandle session, IEnumerable<CreateIndexModel<Associate>> models, CreateManyIndexesOptions options, CancellationToken cancellationToken = default) => null;
    public string CreateOne(CreateIndexModel<Associate> model, CreateOneIndexOptions options = null, CancellationToken cancellationToken = default) => "index name here";
    public string CreateOne(IndexKeysDefinition<Associate> keys, CreateIndexOptions options = null, CancellationToken cancellationToken = default) => "";
    public string CreateOne(IClientSessionHandle session, IndexKeysDefinition<Associate> keys, CreateIndexOptions options = null, CancellationToken cancellationToken = default) => "";
    public string CreateOne(IClientSessionHandle session, CreateIndexModel<Associate> model, CreateOneIndexOptions options = null, CancellationToken cancellationToken = default) => "";
    public Task<string> CreateOneAsync(CreateIndexModel<Associate> model, CreateOneIndexOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<string> CreateOneAsync(IndexKeysDefinition<Associate> keys, CreateIndexOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<string> CreateOneAsync(IClientSessionHandle session, IndexKeysDefinition<Associate> keys, CreateIndexOptions options = null, CancellationToken cancellationToken = default) => null;
    public Task<string> CreateOneAsync(IClientSessionHandle session, CreateIndexModel<Associate> model, CreateOneIndexOptions options = null, CancellationToken cancellationToken = default) => null;
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

public class MockMongoCollection<Associate> : MongoCollectionBase<Associate>
{
    public override void InsertOne(Associate document, InsertOneOptions options = null, CancellationToken cancellationToken = default) {}
    public override MongoCollectionSettings Settings { get => null; }
    public override IBsonSerializer<Associate> DocumentSerializer { get => null; }
    public override IMongoDatabase Database { get => null; }
    public override CollectionNamespace CollectionNamespace { get => null; }
    public override IMongoIndexManager<Associate> Indexes { get => new MockMongoIndexManager<Associate>(); }
    public override Task<IAsyncCursor<TResult>> AggregateAsync<TResult>(PipelineDefinition<Associate, TResult> pipeline, AggregateOptions options = null, CancellationToken cancellationToken = default) => null;
    public override Task<BulkWriteResult<Associate>> BulkWriteAsync(IEnumerable<WriteModel<Associate>> requests, BulkWriteOptions options = null, CancellationToken cancellationToken = default) => null;
    public override Task<IAsyncCursor<TField>> DistinctAsync<TField>(FieldDefinition<Associate, TField> field, FilterDefinition<Associate> filter, DistinctOptions options = null, CancellationToken cancellationToken = default) => null;
    public override Task<IAsyncCursor<TProjection>> FindAsync<TProjection>(FilterDefinition<Associate> filter, FindOptions<Associate, TProjection> options = null, CancellationToken cancellationToken = default) => null;
    public override Task<TProjection> FindOneAndDeleteAsync<TProjection>(FilterDefinition<Associate> filter, FindOneAndDeleteOptions<Associate, TProjection> options = null, CancellationToken cancellationToken = default) => null;
    public override Task<TProjection> FindOneAndReplaceAsync<TProjection>(FilterDefinition<Associate> filter, Associate replacement, FindOneAndReplaceOptions<Associate, TProjection> options = null, CancellationToken cancellationToken = default) => null;
    public override Task<TProjection> FindOneAndUpdateAsync<TProjection>(FilterDefinition<Associate> filter, UpdateDefinition<Associate> update, FindOneAndUpdateOptions<Associate, TProjection> options = null, CancellationToken cancellationToken = default) => null;
    public override Task<IAsyncCursor<TResult>> MapReduceAsync<TResult>(BsonJavaScript map, BsonJavaScript reduce, MapReduceOptions<Associate, TResult> options = null, CancellationToken cancellationToken = default) => null;
    public override IMongoCollection<Associate> WithReadPreference(ReadPreference readPreference) => null;
    public override IMongoCollection<Associate> WithWriteConcern(WriteConcern writeConcern) => null;
    public override IFilteredMongoCollection<TDerivedDocument> OfType<TDerivedDocument>() => null;
    [Obsolete]
    public override Task<long> CountAsync(FilterDefinition<Associate> filter, CountOptions options = null, CancellationToken cancellationToken = default) => null;





}

public class MockMongoDatabase : IMongoDatabase
{
    public IMongoCollection<Associate> GetCollection<Associate>(string name, MongoCollectionSettings settings = null)
    {
        return new MockMongoCollection<Associate>();
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
    public void CreateView<Associate, TResult>(string viewName, string viewOn, PipelineDefinition<Associate, TResult> pipeline, CreateViewOptions<Associate> options = null, CancellationToken cancellationToken = default) {}
    public void CreateView<Associate, TResult>(IClientSessionHandle session, string viewName, string viewOn, PipelineDefinition<Associate, TResult> pipeline, CreateViewOptions<Associate> options = null, CancellationToken cancellationToken = default) {}
    public Task CreateViewAsync<Associate, TResult>(string viewName, string viewOn, PipelineDefinition<Associate, TResult> pipeline, CreateViewOptions<Associate> options = null, CancellationToken cancellationToken = default) => null;
    public Task CreateViewAsync<Associate, TResult>(IClientSessionHandle session, string viewName, string viewOn, PipelineDefinition<Associate, TResult> pipeline, CreateViewOptions<Associate> options = null, CancellationToken cancellationToken = default) => null;
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