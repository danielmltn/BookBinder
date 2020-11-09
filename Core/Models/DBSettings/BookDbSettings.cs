namespace BookBinderBE.Models.DBSettings {

    public class BookDbSettings : IMongoDbSettings 
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IMongoDbSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }

}