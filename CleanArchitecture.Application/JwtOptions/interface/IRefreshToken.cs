namespace CleanArchitecture.Application.Interfaces.Jwt
{
    public interface IRefreshToken
    {
        Task SaveRefreshTokenAsync(string userName, string token, DateTime expires);
        Task<RefreshToken?> GetByTokenAsync(string token, string userName);
        Task DeleteAsync(string token);
    }
}