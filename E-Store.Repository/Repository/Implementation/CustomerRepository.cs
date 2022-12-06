using E_Store.Domain.Models;
using E_Store.EF.Data;
using E_Store.Repository.Infrastructure.Implementation;
using E_Store.Repository.Repository.Interface;

namespace E_Store.Repository.Repository.Implementation
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}