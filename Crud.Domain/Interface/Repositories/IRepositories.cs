namespace Crud.Domain.Interface.Repositories
{
    public interface IRepositories
    {
        List<T> GetListEntity<T>(T entity) where T : class;

        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;
    }
}
