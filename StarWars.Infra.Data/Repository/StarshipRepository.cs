using System;
using Microsoft.EntityFrameworkCore;
using StarWars.Domain.Entities;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Infra.Data.Context;

namespace StarWars.Infra.Data.Repository
{
    public class StarshipRepository : RepositoryBase<Starship>, IStarshipRepository
    {
        public StarshipRepository(StarWarsContext context)
            : base(context)
        {

        }

        public Starship GetMGLT(int valor)
        {
            throw new NotImplementedException();
        }
    }
}
