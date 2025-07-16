namespace CleanArchitecture.Domain.Entities.Products;
public interface IProductRepository : IGeneric<Product>
{
    // Define any additional methods specific to Product repository if needed
    Task<IEnumerable<Product>> GetTopSellingProductsAsync();
}