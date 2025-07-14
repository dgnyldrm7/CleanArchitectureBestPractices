using CleanArchitecture.Application.Common;
using CleanArchitecture.Domain.Products;

namespace CleanArchitecture.Domain.Products;

public interface IProductRepository : IGeneric<Product>
{
    // Define any additional methods specific to Product repository if needed
    Task<IEnumerable<Product>> GetTopSellingProductsAsync();
}