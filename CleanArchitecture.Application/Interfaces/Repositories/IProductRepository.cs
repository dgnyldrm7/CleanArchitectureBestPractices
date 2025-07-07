using CleanArchitecture.Application.Common;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGeneric<Product>
    {
        // Define any additional methods specific to Product repository if needed
        Task<IEnumerable<Product>> GetTopSellingProductsAsync();
    }
}