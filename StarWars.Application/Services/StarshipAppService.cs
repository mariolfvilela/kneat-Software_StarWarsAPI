using System;
using System.Collections.Generic;
using StarWars.Application.ViewModels;
using StarWars.Domain.Interfaces.Repositories;
using AutoMapper;
using StarWars.Domain.Interfaces.Services;
using StarWars.Domain.Entities;
using StarWars.Application.Interfaces;
using StarWars.Lib.Tools;
using System.Threading.Tasks;

namespace StarWars.Application.Services
{
    public class StarshipAppService : BaseAppService<Starship, StarshipViewModel>, IStarshipAppService
    {

        public StarshipAppService(IMapper mapper,
                                  IStarshipService servico)
            : base(mapper, servico)
        {
        }        
    }
}
