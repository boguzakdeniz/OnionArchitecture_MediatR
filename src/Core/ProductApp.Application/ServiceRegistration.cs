﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProductApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection serviceCollection)
        {
            var assembly = Assembly.GetExecutingAssembly();
            serviceCollection.AddAutoMapper(assembly);
            serviceCollection.AddMediatR(config => config.RegisterServicesFromAssembly(assembly)); 
        }
    }
}
