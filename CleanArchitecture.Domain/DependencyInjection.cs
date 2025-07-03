using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Domain
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            // Register domain services here
            // Example: services.AddScoped<IMyDomainService, MyDomainService>();


            //Pipeline Behaviors

            return services;
        }
    }
}