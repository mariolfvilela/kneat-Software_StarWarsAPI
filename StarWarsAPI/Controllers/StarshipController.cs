using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Star_Wars.Application.Interfaces;
using Star_Wars.Application.ViewModels;
using StarWars.Domain.Entities;
using StarWars.Domain.Exceptions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Star_Wars.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class StarshipController : BaseController<Starship, StarshipViewModel>
    {

        public StarshipController(IStarshipAppService app)
            : base(app)
        {
        }


        // [Authorize("Bearer")]
        [AllowAnonymous]
        [HttpGet]
        [Route("Ativos")]
        public ActionResult<StarshipViewModel> Get()
        {
            try
            {
                var dado = app.ListAsync();

                return StatusCode(200,
                     dado
                    );
            }
            catch (EntityValidationException ex)
            {
                return StatusCode(422,
                    new StarshipViewModel()
                    {
                        Mensagem = ex.Label,
                        Mensagens = ex.Mensagens
                    });
            }
            catch (Exception ex)
            {
                return StatusCode(500,
                    new StarshipViewModel()
                    {
                        Exception = ex.Message
                    });
            }
        }

        public async Task<IActionResult> Teste(string id)
        {

            return StatusCode(200,
                    new StarshipViewModel()
                    { });
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Test")]
        public ActionResult Test()
        {
            return StatusCode(200);
        }
    }
}
