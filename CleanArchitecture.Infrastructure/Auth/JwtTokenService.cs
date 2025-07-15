using CleanArchitecture.Application.Interfaces.Jwt;
using CleanArchitecture.Application.JwtOptions;
using CleanArchitecture.Infrastructure.Settings;
using Microsoft.Extensions.Options;

namespace CleanArchitecture.Infrastructure.Auth
{
    //implementasyon
    public class JwtTokenService : ITokenService
    {
        private readonly JwtSettings jwtSettings;

        public JwtTokenService(IOptions<JwtSettings> options)
        {
            this.jwtSettings = options.Value;
        }

        public GenerateAccessTokenResponse GenerateAccessToken(string userId, string userName, IList<string> roles)
        {
            throw new NotImplementedException();
        }

        public string GenerateRefreshToken()
        {
            throw new NotImplementedException();
        }

        public TokenMessageResponse GenerateToken(string userName, IList<string> roles)
        {
            throw new NotImplementedException();
        }
    }
}