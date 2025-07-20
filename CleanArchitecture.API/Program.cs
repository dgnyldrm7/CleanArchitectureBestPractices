namespace CleanArchitecture.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers()
            .AddApplicationPart(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);

        // Register the all services
        builder.Services.AddInfrastructureServices(builder.Configuration);
        builder.Services.AddPersistenceServices(builder.Configuration);
        builder.Services.AddApplicationServices();
        builder.Services.AddDomainServices();
        builder.Services.AddWebApiServices(builder.Configuration);

        // Register all scoped services from the assemblies. (Default lifetime is Scoped!)
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Infrastructure.AssemblyReference).Assembly);
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Persistance.AssemblyReference).Assembly);
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Application.AssemblyReference).Assembly);
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Domain.AssemblyReference).Assembly);
        builder.Services.AddAllScopedServices(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);

        builder.Services.AddDatabaseDeveloperPageExceptionFilter(); // This is used to show detailed error pages in development mode M�KEMMEL B�R �ZELL�K!!!

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseExceptionHandler("/Error");

            //app.UseHsts(); // HSTS is not recommended in development environments
        }

        // UseStatusCodePages yap�s�, HTTP durum kodlar�n� y�netmek i�in kullan�l�r. �rne�in, 404 Not Found durumunda �zel bir sayfa g�stermek i�in kullan�labilir. �zelle�tirme de yap�labilir!
        app.UseStatusCodePages();

        app.MapHub<ChatHub>("/chathub");

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.UseMiddleware<GlobalExceptionMiddleware>();

        app.MapControllers();

        app.Run();
    }
}
