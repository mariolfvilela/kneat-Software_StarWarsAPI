using System;
using AutoMapper;
using Star_Wars.Application.ViewModels;
using Star_Wars.Domain.Entities;

namespace Star_Wars.Application
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<Starship, StarshipViewModel>();
            CreateMap<StarshipViewModel, Starship > ();

        }
    }
}
