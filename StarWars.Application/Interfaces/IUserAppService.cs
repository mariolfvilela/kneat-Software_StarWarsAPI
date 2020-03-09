using System;
using System.Threading.Tasks;
using StarWars.Application.ViewModels;
using StarWars.Domain.Entities;

namespace StarWars.Application.Interfaces
{
    public interface IUserAppService : IAppServicoBase<User, UserViewModel>
    {
        Task<UserViewModel> Login(string username, string password);
    }
}
