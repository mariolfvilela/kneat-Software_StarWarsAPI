﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DotNetCore.Results;
using StarWars.Application.Interfaces;
using StarWars.Application.ViewModels;
using StarWars.Domain.Common;
using StarWars.Domain.Interfaces.Services;
using StarWars.Lib.Tools;

namespace StarWars.Application.Services
{
    public class BaseAppService<TEntity, TEntityViewModel> : IAppServicoBase<TEntity, TEntityViewModel>
        where TEntity : EntityBase
        where TEntityViewModel : ViewModelBase
    {
        protected readonly IServiceBase<TEntity> _service;
        protected readonly IMapper _mapper;

        public BaseAppService(IMapper iMapper, IServiceBase<TEntity> servico)
            : base()
        {
            this._mapper = iMapper;
            this._service = servico;
        }

        public async Task<IDataResult<int>> AddAsync(TEntityViewModel entityViewModel)
        {
            return DataResult<int>.Success(await _service.AddAsync(_mapper.Map<TEntity>(entityViewModel)));
        }

        public async Task<TEntityViewModel> GetByIdAsync(int id)
        {
            return _mapper.Map<TEntityViewModel>(await _service.GetByIdAsync(id));
        }

        public async Task<IEnumerable<TEntityViewModel>> ListAsync()
        {
            return _mapper.Map<IEnumerable<TEntityViewModel>>(await _service.ListAsync());
        }

        public async Task<IResult> RemoveAsync(TEntityViewModel entityViewModel)
        {
            return await _service.RemoveAsync(_mapper.Map<TEntity>(entityViewModel)) ? Result.Success() : Result.Fail();
        }

        public async Task<IResult> RemoveByIdAsync(int id)
        {
            return (await _service.RemoveByIdAsync(id)) ? Result.Success() : Result.Fail(); throw new NotImplementedException();
        }

        public async Task<TEntityViewModel> UpdateAsync(TEntityViewModel entityViewModel)
        {
            return _mapper.Map<TEntityViewModel>(await _service.UpdateAsync(_mapper.Map<TEntity>(entityViewModel)));
        }

        public async Task<IEnumerable<TEntityViewModel>> CalculatingDistanceAsync(long dis)
        {
            var list= _mapper.Map<IEnumerable<StarshipViewModel>>(await API_Consumption.Get(Convert.ToInt32(dis)));
            foreach (var ship in list)
            {
                // Calculate total number of hours that the consumables can last.
                double hours = Calculator.ToHours(Parser.ParseDuration(ship.Consumables));

                // finaly calculate total number of stops required based on the distance, speed and time
                if (int.TryParse(ship.MGLT, out _))
                {
                    ship.ToStop = Calculator.ToStops(dis, Convert.ToInt64(ship.MGLT), hours).ToString();
                }
                else { ship.ToStop = ship.MGLT; }
            }
            return _mapper.Map<IEnumerable<TEntityViewModel>>(list);
        }
    }
}
