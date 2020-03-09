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
            CreateMap<User, UserViewModel>();

            CreateMap<StarshipViewModel, Starship>();
            CreateMap<UserViewModel, User>();

        }
    }
}
