using System;
using StarWars.Domain.Entities;

namespace StarWars.Domain.Interfaces.Repositories
{
    public interface IStarshipRepository : IRepositoryBase<Starship>
    {
        Starship GetMGLT(int valor);
    }
}
