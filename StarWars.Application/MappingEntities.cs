using System;
using AutoMapper;
using Star_Wars.Application.ViewModels;
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
