namespace CleanArchitecture.Infrastructure.Settings
{
    public class EmailSettings
    {
        public string SmtpServer { get; set; } = default!;
        public int Port { get; set; }
    }
}