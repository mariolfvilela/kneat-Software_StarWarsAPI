using System;
using Microsoft.Extensions.DependencyInjection;
using StarWars.Application.Interfaces;
using StarWars.Application.Services;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Domain.Interfaces.Services;
using StarWars.Domain.Service;
using StarWars.Infra.Data.Repository;

namespace StarWars.API.Extensions
{
    public class InjetorDependencias_Temp
    {
        public static void Registrar(IServiceCollection serviceCollection)
        {
            //Aplicação            
            //serviceCollection.AddScoped<IStarshipAppService, StarshipAppService>();

            //Domínio
            serviceCollection.AddScoped<IStarshipService, StarshipServico>();

            //Repositorio
            serviceCollection.AddScoped<IStarshipRepository, StarshipRepository>();
        }
    }
}
