using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Infrastructure.Interface
{
    public interface IDbContext
    {
        public IMongoClient MongoClient { get; set; }

        public IMongoDatabase Database { get; set; }

        IMongoCollection<T> GetCollectionByName<T>(string nameCollection);
    }
}
