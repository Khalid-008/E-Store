using E_Store.Repository.Repository.Interface;

namespace E_Store.Repository.Infrastructure.Interface
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        ICustomerRepository CustomerRepository { get; }

        void save();
    }
}