using CleanArchitecture.Application.DTOs;

namespace CleanArchitecture.Application.Interfaces.Common;

public interface ITokenService
{
    TokenDto GenerateToken(string userId, string role, DateTime expiration);
    string GenerateAccessToken(string userEmail, IList<string> roles);
    string GenerateRefreshToken();
}