using CleanArchitecture.Application.Common;
using CleanArchitecture.Persistance.Repositories.GenericRepository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGeneric<>), typeof(Generic<>));
            return services;
        }
    }
}
