using System;
using StarWars.Application.ViewModels;
using StarWars.Domain.Entities;
using AutoMapper;

namespace StarWars.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Starship, StarshipViewModel>();
        }
    }
}
