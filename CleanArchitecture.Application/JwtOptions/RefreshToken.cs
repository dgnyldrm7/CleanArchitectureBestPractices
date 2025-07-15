namespace CleanArchitecture.Application.JwtOptions
{
    public class RefreshToken
    {
        public string Token { get; set; } = default!;
        public string UserNumber { get; set; } = default!;
        public DateTime Expires { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expires;
    }
}