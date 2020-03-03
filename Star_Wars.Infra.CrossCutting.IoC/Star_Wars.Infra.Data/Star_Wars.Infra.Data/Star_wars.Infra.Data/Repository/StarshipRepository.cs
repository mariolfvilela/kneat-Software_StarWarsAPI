using System;
using Microsoft.EntityFrameworkCore;
using Star_Wars.Domain.Entities;
using Star_Wars.Domain.Interfaces.Repositories;
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
