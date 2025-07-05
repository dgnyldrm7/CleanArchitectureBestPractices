namespace CleanArchitecture.Infrastructure.Settings;

public class DatabaseSettings
{
    public string DefaultConnection { get; set; } = default!;
    public string Postgre { get; set; } = default!;
    public string SqlServer { get; set; } = default!;
    public string SqLite { get; set; } = default!;
}