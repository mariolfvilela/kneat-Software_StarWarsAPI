using System;
using Star_Wars.Application.ViewModels;
using Star_Wars.Domain.Entities;
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
