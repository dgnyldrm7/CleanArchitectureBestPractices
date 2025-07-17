using CleanArchitecture.WebApi.ExceptionHandlers;

namespace CleanArchitecture.WebApi
{
    public static class DependencyInjection
    {
        public static void AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
        {     
            //KULALIMINI ARAŞTIR!
            //services.AddProblemDetails();

            // If you singlethon or transient services, you can register them here
            // Example:
            // builder.Services.AddSingleton<ISingletonService, SingletonService>();
            services.AddScoped<ISignalRTypeSafe>(provider =>
            {
                var hubContext = provider.GetRequiredService<IHubContext<ChatHub>>();
                return new SignalRService<ChatHub>(hubContext);
            });

            //SignalR entegrasyonu
            services.AddSignalR();

            //Swagger işlemleri için eklendi!
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // Register the HttpContextAccessor to access the current HTTP context
            services.AddHttpContextAccessor();
                                
            
            // Register the custom middleware for handling exceptions globally - Burada özel çalışma yapmalıyız! Daha dikkatli çalışmalısın!
            //services.AddExceptionHandler<GlobalExceptionHandler>();
            
            //services.AddExceptionHandler<BannedColorExceptionHandler>();

            services.AddExceptionHandler<BannedColorExceptionHandler>();
        }
    }
}
