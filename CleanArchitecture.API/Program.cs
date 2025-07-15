namespace CleanArchitecture.API;
using CleanArchitecture.Application;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Infrastructure.SignalR;
using CleanArchitecture.Persistance;
using CleanArchitecture.Presentation.Hubs;
using CleanArchitecture.Shared;
using Microsoft.AspNetCore.SignalR;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers()
            .AddApplicationPart(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Register the HttpContextAccessor to access the current HTTP context
        builder.Services.AddHttpContextAccessor();

        // Register the all services
        builder.Services.AddInfrastructureServices(builder.Configuration);
        builder.Services.AddPersistenceServices(builder.Configuration);
        builder.Services.AddApplicationServices();
        builder.Services.AddDomainServices();

        // Register all scoped services from the assemblies. (Default lifetime is Scoped!)
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Infrastructure.AssemblyReference).Assembly);
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Persistance.AssemblyReference).Assembly);
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Application.AssemblyReference).Assembly);
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Domain.AssemblyReference).Assembly);
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);

        // If you singlethon or transient services, you can register them here
        // Example:
        // builder.Services.AddSingleton<ISingletonService, SingletonService>();
        builder.Services.AddScoped<ISignalRTypeSafe>(provider =>
        {
            var hubContext = provider.GetRequiredService<IHubContext<ChatHub>>();
            return new SignalRService<ChatHub>(hubContext);
        });

        builder.Services.AddSignalR();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapHub<ChatHub>("/chathub");

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
