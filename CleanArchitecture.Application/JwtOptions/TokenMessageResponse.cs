namespace CleanArchitecture.Application.JwtOptions
{
    public class TokenMessageResponse
    {
        public string Message { get; set; } = default!;
        public string AccessToken { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
    }
}