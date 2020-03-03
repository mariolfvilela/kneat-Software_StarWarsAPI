using System;
using Star_Wars.Domain.Entities;
using Star_Wars.Domain.Interfaces.Repositories;
using Star_Wars.Domain.Interfaces.Services;

namespace Star_Wars.Domain.Service
{
    public class StarshipServico : ServiceBase<Starship>, IStarshipService
    {
        public StarshipServico(IStarshipRepository repositorio)
            : base(repositorio)
        {
        }
    }
}
