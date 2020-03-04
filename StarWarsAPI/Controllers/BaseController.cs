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
        readonly protected IAppServicoBase<Entity, EntityViewModel> app;

        protected BaseController(IAppServicoBase<Entity, EntityViewModel> app)
        {
            this.app = app;
        }

        // [Authorize("Bearer")]
        [AllowAnonymous]
        [HttpGet]
        [Route("")]
        public async virtual Task<IActionResult> ListAsync()
        {
            return new OkObjectResult(await app.ListAsync());
        }

        // [Authorize("Bearer")]
        [AllowAnonymous]
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<EntityViewModel>> GetById(int id)
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
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<EntityViewModel>> Add([FromBody] EntityViewModel dado)
        {
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
        [AllowAnonymous]
        [HttpPut]
        public async Task<ActionResult<EntityViewModel>> Update([FromBody] EntityViewModel dado)
        {
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
        [AllowAnonymous]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> RemoveById(int id)
        {
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
