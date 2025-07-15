using CleanArchitecture.Application.JwtOptions;

namespace CleanArchitecture.Application.Interfaces.Common;

public interface ITokenService
{
    TokenMessageResponse GenerateToken(string userId, string role, DateTime expiration);
    string GenerateAccessToken(string userEmail);
    string GenerateRefreshToken();
}