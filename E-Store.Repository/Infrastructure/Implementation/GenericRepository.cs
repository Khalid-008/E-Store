using E_Store.EF.Data;
using E_Store.Repository.Infrastructure.Interface;
using System.Data.Entity.Migrations;

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

        public void delete(int id)
        {
            var item = context.Set<T>().Find(id);
            context.Set<T>().Remove(item);
        }

        public void updateById(T obj)
        {
            context.Set<T>().AddOrUpdate(obj);
        }
    }
}