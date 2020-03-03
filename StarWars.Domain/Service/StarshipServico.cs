using System;
using StarWars.Domain.Entities;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Domain.Interfaces.Services;

namespace StarWars.Domain.Service
{
    public class StarshipServico : ServiceBase<Starship>, IStarshipService
    {
        public StarshipServico(IStarshipRepository repositorio)
            : base(repositorio)
        {
        }
    }
}
