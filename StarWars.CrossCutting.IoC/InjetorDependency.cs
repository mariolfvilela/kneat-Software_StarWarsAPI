using System;
using Microsoft.Extensions.DependencyInjection;
using Star_Wars.Application.Interfaces;
using Star_Wars.Application.Services;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Domain.Interfaces.Services;
using StarWars.Domain.Service;
using Star_Wars.Infra.Data.Repository;

namespace Star_Wars.CrossCutting.IoC
{
    public class InjetorDependency
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            //svcCollection.AddTransient(typeof(IAppServicoBase<,>), typeof(BaseAppService<,>));
            //svcCollection.AddTransient<IStarshipAppService, StarshipAppService>();

            //Domínio
            //svcCollection.AddTransient(typeof(IServiceBase<>), typeof(ServiceBase<>));
            //svcCollection.AddTransient<IStarshipService, StarshipServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddScoped<IStarshipRepository, StarshipRepository>();
        }
    }
}
