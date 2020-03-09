using System;
using System.Threading.Tasks;
using AutoMapper;
using StarWars.Application.Interfaces;
using StarWars.Application.ViewModels;
using StarWars.Domain.Entities;
using StarWars.Domain.Interfaces.Services;

namespace StarWars.Application.Services
{
    public class UserAppService : BaseAppService<User, UserViewModel>, IUserAppService
    {
        protected readonly IUserService _service;

        public UserAppService(IMapper iMapper, IUserService service)
            : base(iMapper, service)
        {
            _service = service;
        }

        public async Task<UserViewModel> Login(string username, string password)
        {
            return _mapper.Map<UserViewModel>(await _service.Login(username, password));
        }
    }
}
