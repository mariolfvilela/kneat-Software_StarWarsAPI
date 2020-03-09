using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWars.Domain.Common;
using StarWars.Domain.Entities;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Infra.Data.Context;

namespace StarWars.Infra.Data.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(StarWarsContext contexto)
            : base(contexto)
        {
        }

        public async Task<User> Login(string username, string password)
        {
            return GetUser().Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password)
                .Select(x => { x.Password = ""; return x; })
                .FirstOrDefault();
        }

        private IEnumerable<User> GetUser()
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "batman", Password = "batman", Roles = Roles.Admin });
            users.Add(new User { Id = 2, Username = "robin", Password = "robin", Roles = Roles.User });
            return users;
        }
    }
}
