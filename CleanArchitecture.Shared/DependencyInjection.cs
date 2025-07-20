namespace CleanArchitecture.Shared
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAllScopedServices(this IServiceCollection services, Assembly assembly)
        {
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                if (!type.IsClass || type.IsAbstract || type.IsGenericType || typeof(Exception).IsAssignableFrom(type))
                    continue;

                if (typeof(IHostedService).IsAssignableFrom(type))
                    continue;

                var interfaces = type.GetInterfaces();

                foreach (var iface in interfaces)
                {
                    services.AddScoped(iface, type);
                }
            }

            return services;
        }
    }
}
