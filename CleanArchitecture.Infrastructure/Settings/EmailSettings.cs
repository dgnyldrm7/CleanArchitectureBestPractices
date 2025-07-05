namespace CleanArchitecture.Infrastructure.Settings
{
    public class EmailSettings
    {
        public string SmtpHost { get; set; } = default!;
        public int Port { get; set; }
        public string SenderEmail { get; set; } = default!;
    }
}