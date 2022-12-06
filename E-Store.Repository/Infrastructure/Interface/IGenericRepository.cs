namespace E_Store.Repository.Infrastructure.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);

        IEnumerable<T> GetAll();

        void Add(T obj);

        void update(T obj);

        void Remove(T obj);
    }
}