namespace CleanArchitecture.Domain.Base;

public abstract class BaseEntity
{
    protected BaseEntity()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; } = default!;
}