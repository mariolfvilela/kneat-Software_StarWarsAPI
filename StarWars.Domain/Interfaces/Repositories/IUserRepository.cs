using System;
using System.Threading.Tasks;
using StarWars.Domain.Entities;

namespace StarWars.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User> Login(string username, string password);
    }
}
