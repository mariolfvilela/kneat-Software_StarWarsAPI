using System;
using AutoMapper;
using StarWars.Application.ViewModels;
using StarWars.Domain.Entities;

namespace StarWars.Application
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<Starship, StarshipViewModel>();
            CreateMap<StarshipViewModel, Starship>();

        }
    }
}
