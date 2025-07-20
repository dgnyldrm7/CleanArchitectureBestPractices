namespace CleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));

            services.Configure<DatabaseSettings>(configuration.GetSection("DatabaseSettings"));

            services.AddHostedService<MyBackgroundService>();


            return services;
        }
    }
}
