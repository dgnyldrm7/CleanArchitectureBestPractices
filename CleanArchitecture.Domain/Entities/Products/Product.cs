namespace CleanArchitecture.Domain.Entities.Products
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}