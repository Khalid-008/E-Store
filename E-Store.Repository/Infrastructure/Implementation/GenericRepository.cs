using E_Store.EF.Data;
using E_Store.Repository.Infrastructure.Interface;

namespace E_Store.Repository.Infrastructure.Implementation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext context;

        //private readonly ILogger logger;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
            //this.logger = logger;
        }

        public void Add(T obj)
        {
            context.Set<T>().Add(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            context.Set<T>().Remove(obj);
        }

        public void update(T obj)
        {
            context.Set<T>().Update(obj);
        }
    }
}