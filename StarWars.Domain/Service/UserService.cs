using System;
using System.Threading.Tasks;
using StarWars.Domain.Entities;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Domain.Interfaces.Services;

namespace StarWars.Domain.Service
{
    public class UserService : ServiceBase<User>, IUserService
    {
        protected readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public async Task<User> Login(string username, string password)
        {
            return await _repository.Login(username, password);
        }
    }
}
