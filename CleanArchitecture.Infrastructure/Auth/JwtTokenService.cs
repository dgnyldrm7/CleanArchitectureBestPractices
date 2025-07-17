namespace CleanArchitecture.Infrastructure.Auth
{
    public class JwtTokenService : ITokenService
    {
        private readonly JwtSettings jwtSettings;

        public JwtTokenService(IOptions<JwtSettings> options)
        {
            this.jwtSettings = options.Value;
        }

        public string GenerateAccessToken(string userEmail)
        {
            throw new NotImplementedException();
        }

        public string GenerateRefreshToken()
        {
            throw new NotImplementedException();
        }

        public TokenMessageResponse GenerateToken(string userId, string role, DateTime expiration)
        {
            throw new NotImplementedException();
        }
    }
}