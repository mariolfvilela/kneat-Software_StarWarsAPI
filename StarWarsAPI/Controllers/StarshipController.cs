using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarWars.Application.Interfaces;
using StarWars.Application.ViewModels;
using StarWars.Domain.Entities;
using StarWars.Domain.Exceptions;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarWars.API.Controllers
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
        [Route("Distance/{MGLT:int}")]
        public async Task<ActionResult<StarshipCoverDistanceViewModel>> GetAsync(int MGLT)
        {
            try
            {
                var dado = await app.CalculatingDistanceAsync(MGLT);

                return StatusCode(200,
                     dado
                     .Distinct()
                     .OrderBy(c=>c.MGLT)
                     .ThenBy(c => c.Name)
                     .Select(c=>new { a = c.Name+" needs to stop: "+c.MGLT})
                     .Select(c=>c.a).ToList()
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
        //[AllowAnonymous]
        //[HttpGet]
        //[Route("Test2")]
        //public async Task<IActionResult> Teste(string id)
        //{

        //    return StatusCode(200,
        //            new StarshipViewModel()
        //            { });
        //}

        //[AllowAnonymous]
        //[HttpGet]
        //[Route("Test")]
        //public ActionResult Test()
        //{
        //    return StatusCode(200);
        //}
    }
}
