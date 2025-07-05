
namespace CleanArchitecture.API;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Persistance;
using CleanArchitecture.Application;
using CleanArchitecture.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers()
            .AddApplicationPart(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Register the all services
        builder.Services.AddInfrastructureServices(builder.Configuration);
        builder.Services.AddPersistanceServices();
        builder.Services.AddApplicationServices();
        builder.Services.AddDomainServices();


        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
