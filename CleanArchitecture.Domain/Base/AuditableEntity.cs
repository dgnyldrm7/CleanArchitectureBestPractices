namespace CleanArchitecture.Domain.Base
{
    public abstract class AuditableEntity : BaseEntity
    {
        public AuditableEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
