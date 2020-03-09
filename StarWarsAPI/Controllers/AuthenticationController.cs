using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StarWars.Application.Interfaces;
using StarWars.Application.ViewModels;
using StarWarsAPI.Extensions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarWarsAPI.Controllers
{
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate(
            [FromServices]IUserAppService app,
            [FromServices]IConfiguration iconfiguration,
            [FromBody]UserViewModel userViewModel)
        {
            try
            {
                var user = await app.Login(userViewModel.Username, userViewModel.Password);

                if (user == null)
                    return NotFound(new { message = "Username or password is invalid" });

                string token = TokenService.GenerateToken(user, iconfiguration);
                return new OkObjectResult(new
                {
                    user = user,
                    token = token
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("employee")]
        [Authorize(Roles = "employee,manager")]
        public string Employee() => "Funcionário";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Manager() => "Gerente";
    }
}
