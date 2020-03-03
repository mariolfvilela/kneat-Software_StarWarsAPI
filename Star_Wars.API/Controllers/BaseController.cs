using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Star_Wars.Application.Interfaces;
using Star_Wars.Application.ViewModels;
using Star_Wars.Domain.Common;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Star_Wars.API.Controllers
{

    public abstract class BaseController<Entity, EntityViewModel> : ControllerBase
        where Entity : EntityBase
        where EntityViewModel : ViewModelBase
    {
        protected readonly IAppServicoBase<Entity, EntityViewModel> _app;

        protected BaseController(IAppServicoBase<Entity, EntityViewModel> app)
        {
            this._app = app;
        }
    }
}
