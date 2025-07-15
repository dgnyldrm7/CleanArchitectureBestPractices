using CleanArchitecture.Application.Common;
using CleanArchitecture.Persistance.Context;
using CleanArchitecture.Persistance.Identity;
using CleanArchitecture.Persistance.Repositories.GenericRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register the DbContext with SQL Server and specify the migrations assembly
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("SqlServer"),
                    sqlOptions => sqlOptions.MigrationsAssembly(typeof(CleanArchitecture.Persistance.AssemblyReference).Assembly.FullName)

                )
            );

            // Register the IdentityDbContext with SQL Server and specify the migrations assembly
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

            services.AddScoped(typeof(IGeneric<>), typeof(Generic<>));

            return services;
        }
    }
}