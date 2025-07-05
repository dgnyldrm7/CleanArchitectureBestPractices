namespace CleanArchitecture.Application.Interfaces.Common
{
    public interface ICurrentUserService
    {
        string? UserId { get; }
        string? UserName { get; }
        string? UserRole { get; }
    }
}
