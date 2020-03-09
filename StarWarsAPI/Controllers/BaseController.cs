using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StarWars.Application.Interfaces;
using StarWars.Application.ViewModels;
using StarWars.Domain.Common;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StarWars.API.Controllers
{

    public abstract class BaseController<Entity, EntityViewModel> : ControllerBase
        where Entity : EntityBase
        where EntityViewModel : ViewModelBase
    {
        //readonly protected IAppServicoBase<Entity, EntityViewModel> app;

        //protected BaseController(IAppServicoBase<Entity, EntityViewModel> app)
        //{
        //    this.app = app;
        //}

        // [Authorize("Bearer")]
        //[Obsolete("Deprecated")]
        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [AllowAnonymous]
        [HttpGet]
        [Route("")]
        public async virtual Task<ActionResult<List<EntityViewModel>>> ListAsync([FromServices] IAppServicoBase<Entity, EntityViewModel> app)
        {
            return new OkObjectResult(await app.ListAsync());
        }

        // [Authorize("Bearer")]
        //[Obsolete("Deprecated")]
        [AllowAnonymous]
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<EntityViewModel>> GetById(
            [FromServices] IAppServicoBase<Entity, EntityViewModel> app,
            int id)
        {
            try
            {
                return new OkObjectResult(await app.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        // [Authorize("Bearer")]
        //[Obsolete("Deprecated")]
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<EntityViewModel>> Post(
            [FromServices] IAppServicoBase<Entity, EntityViewModel> app,
            [FromBody] EntityViewModel dado)
        {
            // Checks whether the data is valid
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                return new OkObjectResult(await app.AddAsync(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // [Authorize("Bearer")]
        //[Obsolete("Deprecated")]
        [AllowAnonymous]
        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<EntityViewModel>> Put(
            [FromServices] IAppServicoBase<Entity, EntityViewModel> app,
            int id,
            [FromBody] EntityViewModel dado)
        {
            // Checks whether the given ID is the same as the model
            if (id != dado.Id)
                return NotFound(new { message = "Id not found" });

            // Checks whether the data is valid
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                return new OkObjectResult(await app.UpdateAsync(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // [Authorize("Bearer")]
        //[Obsolete("Deprecated")]
        [AllowAnonymous]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> RemoveById(
            [FromServices] IAppServicoBase<Entity, EntityViewModel> app,
            int id)
        {
            var entiry = app.GetByIdAsync(id).Result;
            if (entiry == null)
                return NotFound(new { message = "Id not found" });

            try
            {
                return new OkObjectResult(await app.RemoveByIdAsync(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
