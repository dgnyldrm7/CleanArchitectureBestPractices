using CleanArchitecture.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services)
        {
            // Register your persistence-related services here
            // For example, DbContext, repositories, etc.
            // services.AddDbContext<ApplicationDbContext>(options => ...);
            // services.AddScoped<IRepository, Repository>();


            // Register the AppDbContext with PostgreSQL configuration!
            services.AddDbContext<AppDbContext>(c =>
            {
                c.UseNpgsql("Postgre", options =>
                {
                    options.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName);
                });
            });

            return services;
        }
    }
}
