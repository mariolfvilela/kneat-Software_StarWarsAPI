using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StarWars.Application.Interfaces;
using StarWars.Application.ViewModels;
using StarWars.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace StarWars.Application.Interfaces
{
    public interface IStarshipAppService : IAppServicoBase<Starship, StarshipViewModel>
    {
        
    }
}
