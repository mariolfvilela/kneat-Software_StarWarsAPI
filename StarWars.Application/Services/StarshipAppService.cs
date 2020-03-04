using System;
using System.Collections.Generic;
using StarWars.Application.ViewModels;
using StarWars.Domain.Interfaces.Repositories;
using AutoMapper;
using StarWars.Domain.Interfaces.Services;
using StarWars.Domain.Entities;
using StarWars.Application.Interfaces;

namespace StarWars.Application.Services
{
    public class StarshipAppService : BaseAppService<Starship, StarshipViewModel>, IStarshipAppService
    {

        public StarshipAppService(IMapper mapper,
                                  IStarshipService servico)
            : base(mapper, servico)
        {
        }

        public IEnumerable<StarshipViewModel> SelecionarAtivos()
        {
            throw new NotImplementedException();
        }
    }
}
