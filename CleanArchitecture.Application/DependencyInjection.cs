﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CleanArchitecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Register application services here
            // Example: services.AddScoped<IMyApplicationService, MyApplicationService>();

            //Pipeline Behaviors
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(MyPipelineBehavior<,>));


            //Kullanım mantığını öğren
            var assembly = Assembly.GetExecutingAssembly();

            return services;
        }
    }
}
