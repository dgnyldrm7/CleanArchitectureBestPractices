using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Persistance.Seed
{
    public class ProductSeeding : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Seed initial data for the Product entity
            builder.HasData(
                new Product
                {
                    Id = "sldjfnsdf",
                    CreatedAt = DateTime.UtcNow,
                    Name = "Sample Product 1",
                    Description = "This is a sample product description for product 1.",                    
                }
            );
        }
    }
}
