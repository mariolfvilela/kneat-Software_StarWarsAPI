using System;
using Microsoft.Extensions.DependencyInjection;
using Star_Wars.Application.Interfaces;
using Star_Wars.Application.Services;
using Star_Wars.Domain.Interfaces.Repositories;
using Star_Wars.Domain.Interfaces.Services;
using Star_Wars.Domain.Service;
using Star_Wars.Infra.Data.Repository;

namespace Star_Wars.API.Extensions
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
