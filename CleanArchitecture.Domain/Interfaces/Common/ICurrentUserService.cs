namespace CleanArchitecture.Domain.Interfaces.Common
{
    public interface ICurrentUserService
    {
        string? UserId { get; }
        string? UserName { get; }
        string? UserRole { get; }
    }
}
