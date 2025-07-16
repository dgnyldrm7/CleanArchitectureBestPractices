namespace CleanArchitecture.Application.Interfaces.Jwt
{
    public interface IRemovedExpiredRefreshTokenService
    {
        Task RemovedExpiredRefreshTokenAsync();
    }
}