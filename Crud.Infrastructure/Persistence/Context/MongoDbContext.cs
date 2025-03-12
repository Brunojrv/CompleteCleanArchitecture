using Crud.Infrastructure.Interface;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace Crud.Infrastructure.Persistence.Context
{
    public class MongoDbContext : IDbContext
    {
        private string _connectionString { get; set; }

        private string _databaseName { get; set; }

        public IMongoClient MongoClient { get; set; }

        public IMongoDatabase Database { get; set; }

        public MongoDbContext(string connectionString, string databaseName)
        {
            _connectionString = connectionString;
            _databaseName = databaseName;

            ValidConnectionString(connectionString);
            ValidDatabase(databaseName);

            MongoClient = new MongoClient(connectionString);
            Database = MongoClient.GetDatabase(databaseName);
        }

        public IMongoCollection<T> GetCollectionByName<T>(string nameCollection)
        {
            if (string.IsNullOrEmpty(nameCollection))
                throw new ArgumentException("name collection  is required.", nameof(nameCollection));

            return Database.GetCollection<T>(nameCollection);
        }

        private void ValidConnectionString(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("Connection string is required.", nameof(connectionString));
        }

        private void ValidDatabase(string databaseName)
        {
            if (string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException("Database name is required.", nameof(databaseName));
        }
    }
}
