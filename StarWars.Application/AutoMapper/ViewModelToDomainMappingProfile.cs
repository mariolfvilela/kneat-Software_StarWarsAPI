using System;
using StarWars.Application.ViewModels;
using StarWars.Domain.Entities;
using AutoMapper;

namespace StarWars.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<StarshipViewModel, Starship>();
        }
    }
}
