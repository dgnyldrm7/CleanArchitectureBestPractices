namespace CleanArchitecture.WebApi
{
    public static class DependencyInjection
    {
        public static void AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
        {     
            // If you singlethon or transient services, you can register them here
            // Example:
            // builder.Services.AddSingleton<ISingletonService, SingletonService>();
            services.AddScoped<ISignalRTypeSafe>(provider =>
            {
                var hubContext = provider.GetRequiredService<IHubContext<ChatHub>>();
                return new SignalRService<ChatHub>(hubContext);
            });

            services.AddMemoryCache();

            services.AddSignalR();

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddHttpContextAccessor();
                                
            services.AddExceptionHandler<GlobalExceptionHandler>();
            services.AddProblemDetails();
        }
    }
}
