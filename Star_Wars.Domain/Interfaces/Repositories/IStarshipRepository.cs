using System;
using Star_Wars.Domain.Entities;

namespace Star_Wars.Domain.Interfaces.Repositories
{
    public interface IStarshipRepository : IRepositoryBase<Starship>
    {
        Starship GetMGLT(int valor);
    }
}
