using E_Store.Domain.Models;
using E_Store.EF.Data;
using E_Store.Repository.Infrastructure.Implementation;
using E_Store.Repository.Repository.Interface;

namespace E_Store.Repository.Repository.Implementation
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}