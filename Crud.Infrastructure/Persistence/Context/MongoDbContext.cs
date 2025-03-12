using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Infrastructure.Interface;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace Crud.Infrastructure.Persistence.Context
{
    public class MongoDbContext : IDbContext
    {
        public string _connectionString { get; set; }

        public string _databaseName { get; set; }

        public static IMongoClient MongoClient { get; set; }

        public static IMongoDatabase Database { get; private set; }

        public MongoDbContext(string connectionString, string databaseName)
        {
            _connectionString = connectionString;
            _databaseName = databaseName;

            ValidConnectionString(connectionString);
            ValidDatabase(databaseName);

            MongoClient = new MongoClient(connectionString);
            Database = MongoClient.GetDatabase(databaseName);
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
