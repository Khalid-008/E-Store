using E_Store.EF.Data;
using E_Store.Repository.Infrastructure.Interface;
using E_Store.Repository.Repository.Interface;

namespace E_Store.Repository.Infrastructure.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        //private readonly ILogger logger;
        public IProductRepository ProductRepository { get; set; }

        public ICustomerRepository CustomerRepository { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }

        public UnitOfWork(ApplicationDbContext context, IProductRepository ProductRepository, ICustomerRepository customerRepository, ICategoryRepository categoryRepository)
        {
            this.context = context;
            //this.logger = logger;
            this.ProductRepository = ProductRepository;
            this.CustomerRepository = customerRepository;
            this.CategoryRepository = categoryRepository;
        }

        public void save()
        {
            context.SaveChanges();
        }
    }
}