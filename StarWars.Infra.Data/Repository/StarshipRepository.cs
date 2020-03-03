using System;
using Microsoft.EntityFrameworkCore;
using StarWars.Domain.Entities;
using StarWars.Domain.Interfaces.Repositories;
using Star_Wars.Infra.Data.Context;

namespace Star_Wars.Infra.Data.Repository
{
    public class StarshipRepository : RepositoryBase<Starship>, IStarshipRepository
    {
        public StarshipRepository(Star_WarsContext context)
            : base(context)
        {

        }

        public Starship GetMGLT(int valor)
        {
            throw new NotImplementedException();
        }
    }
}
