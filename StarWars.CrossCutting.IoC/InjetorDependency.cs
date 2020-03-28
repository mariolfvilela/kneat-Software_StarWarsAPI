using System;
using Microsoft.Extensions.DependencyInjection;
using StarWars.Application.Interfaces;
using StarWars.Application.Services;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Domain.Interfaces.Services;
using StarWars.Domain.Service;
using Microsoft.Extensions.Configuration;
using StarWars.Infra.Data.Repository;

namespace StarWars.CrossCutting.IoC
{
    public class InjetorDependency
    {
        public static void Registrar(IServiceCollection svcCollection)
        {

            //Aplicação
            svcCollection.AddScoped(typeof(IAppServicoBase<,>), typeof(BaseAppService<,>));
            svcCollection.AddScoped<IStarshipAppService, StarshipAppService>();
            svcCollection.AddScoped<IUserAppService, UserAppService>();

            //Domínio
            svcCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            svcCollection.AddScoped<IStarshipService, StarshipServico>();
            svcCollection.AddScoped<IUserService, UserService>();

            //Repositorio
            svcCollection.AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddTransient<IStarshipRepository, StarshipRepository>();
            svcCollection.AddTransient<IUserRepository, UserRepository>();

            // https://balta.io/blog/aspnet-core-dependency-injection
            // AddScoped
            // AddTransient
        }
    }
}
