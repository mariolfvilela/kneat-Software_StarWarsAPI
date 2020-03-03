using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Star_Wars.Application.Interfaces;
using Star_Wars.Application.ViewModels;
using StarWars.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Star_Wars.Application.Interfaces
{
    public interface IStarshipAppService : IAppServicoBase<Starship, StarshipViewModel>
    {
        IEnumerable<StarshipViewModel> SelecionarAtivos();
    }
}
