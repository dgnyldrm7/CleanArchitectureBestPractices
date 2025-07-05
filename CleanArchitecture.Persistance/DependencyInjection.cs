using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistanceService(this IServiceCollection services)
        {
            // Register your persistence-related services here
            // For example, DbContext, repositories, etc.
            // services.AddDbContext<ApplicationDbContext>(options => ...);
            // services.AddScoped<IRepository, Repository>();

            return services;
        }
    }
}
