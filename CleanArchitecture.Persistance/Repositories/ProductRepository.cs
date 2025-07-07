using CleanArchitecture.Application.Interfaces.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistance.Context;
using CleanArchitecture.Persistance.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistance.Repositories
{
    public class ProductRepository : Generic<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context) { }


        public async Task<IEnumerable<Product>> GetTopSellingProductsAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}