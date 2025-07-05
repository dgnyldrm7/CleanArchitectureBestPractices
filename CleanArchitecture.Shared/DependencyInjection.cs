using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitecture.Shared
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAllScopedServices(this IServiceCollection services, Assembly assembly)
        {
            var types = assembly.GetTypes();

            var implementations = types
                .Where(t => t.IsClass && !t.IsAbstract)
                .ToList();

            foreach (var impl in implementations)
            {
                var interfaces = impl.GetInterfaces();

                foreach (var iface in interfaces)
                {
                    services.AddScoped(iface, impl);
                }
            }

            return services;
        }
    }
}
