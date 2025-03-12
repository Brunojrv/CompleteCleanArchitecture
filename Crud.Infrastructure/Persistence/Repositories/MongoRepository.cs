using Crud.Domain.Interface.Repositories;
using Crud.Infrastructure.Interface;
using Crud.Infrastructure.Shared.Validator;
using MongoDB.Driver;

namespace Crud.Infrastructure.Persistence.Repositories
{
    public class MongoRepository : IRepositories
    {
        public MongoRepository(IDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IDbContext _dbContext { get; set; }

        public void Add<T>(T entity) where T : class
        {
            SharedValidator.ValidEntity(entity);

            var collection = _dbContext.GetCollectionByName<T>(typeof(T).Name);
            collection.InsertOne(entity);
        }

        public void Delete<T>(T entity, string id) where T : class
        {
            SharedValidator.ValidEntity(entity);

            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException("Invalid Id");

            var collection = _dbContext.GetCollectionByName<T>(typeof(T).Name);
            var filter = Builders<T>.Filter.Eq("Id", id);

            collection.DeleteOne(filter);
        }

        public IQueryable<T> GetListEntity<T>(T entity) where T : class
        {
            SharedValidator.ValidEntity(entity);

            return _dbContext.GetCollectionByName<T>(typeof(T).Name).AsQueryable();
        }

        public void Update<T>(T entity, string id) where T : class
        {
            SharedValidator.ValidEntity(entity);

            var collection = _dbContext.GetCollectionByName<T>(typeof(T).Name);
            var filter = Builders<T>.Filter.Eq("Id", id);

            collection.ReplaceOne(filter, entity);
        }
    }
}
