using System;
using System.Threading.Tasks;
using StarWars.Domain.Entities;

namespace StarWars.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        Task<User> Login(string username, string password);
    }
}
