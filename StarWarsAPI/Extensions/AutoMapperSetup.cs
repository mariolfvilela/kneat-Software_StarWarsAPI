using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using StarWars.Application.AutoMapper;

namespace StarWars.API.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services, object p)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //services.AddAutoMapper();

            // Registering Mappings automatically only works if the 
            // Automapper Profile classes are in ASP.NET project
            AutoMapperConfig.RegisterMappings();
        }
    }
}
