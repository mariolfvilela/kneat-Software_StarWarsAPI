using System;
using Microsoft.Extensions.DependencyInjection;
using Star_Wars.Application.Interfaces;
using Star_Wars.Application.Services;
using Star_Wars.Domain.Interfaces.Repositories;
using Star_Wars.Domain.Interfaces.Services;
using Star_Wars.Domain.Service;
using Star_Wars.Infra.Data.Repository;

namespace Star_Wars.CrossCutting.IoC
{
    public class InjetorDependency
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppServicoBase<,>), typeof(BaseAppService<,>));
            svcCollection.AddScoped<IStarshipAppService, StarshipAppService>();

            //Domínio
            svcCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            svcCollection.AddScoped<IStarshipService, StarshipServico>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddScoped<IStarshipRepository, StarshipRepository>();
        }
    }
}
