using System;
using Star_Wars.Application.ViewModels;
using StarWars.Domain.Entities;
using AutoMapper;

namespace Star_Wars.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<StarshipViewModel, Starship>();
        }
    }
}
