using System;
using Star_Wars.Application.ViewModels;
using StarWars.Domain.Entities;
using AutoMapper;

namespace Star_Wars.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Starship, StarshipViewModel>();
        }
    }
}
