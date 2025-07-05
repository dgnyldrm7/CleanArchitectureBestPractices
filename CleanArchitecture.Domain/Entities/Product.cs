using CleanArchitecture.Domain.Base;

namespace CleanArchitecture.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}