namespace CleanArchitecture.Application.JwtOptions
{
    public class GenerateAccessTokenResponse
    {
        public string Token { get; set; } = default!;
        public string Jti { get; set; } = default!;
    }
}