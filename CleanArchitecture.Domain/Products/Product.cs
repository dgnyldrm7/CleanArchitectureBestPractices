using CleanArchitecture.Domain.Base;

namespace CleanArchitecture.Domain.Products
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}