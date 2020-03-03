using System;
using System.Collections.Generic;
using Star_Wars.Application.ViewModels;
using Star_Wars.Domain.Interfaces.Repositories;
using AutoMapper;
using Star_Wars.Domain.Interfaces.Services;
using Star_Wars.Domain.Entities;
using Star_Wars.Application.Interfaces;

namespace Star_Wars.Application.Services
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
