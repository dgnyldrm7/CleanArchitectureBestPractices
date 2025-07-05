using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // Register infrastructure services here
            // Example: services.AddScoped<IMyInfrastructureService, MyInfrastructureService>();

            // Register repositories, data access, etc.
            // Example: services.AddScoped<IMyRepository, MyRepository>();

            // Register any other infrastructure-related services

            return services;
        }
    }
}
