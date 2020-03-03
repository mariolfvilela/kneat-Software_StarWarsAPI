using System;
using System.Collections.Generic;
using AutoMapper;
using Star_Wars.Application.Interfaces;
using Star_Wars.Application.ViewModels;
using Star_Wars.Domain.Common;
using Star_Wars.Domain.Interfaces.Services;

namespace Star_Wars.Application.Services
{
    public abstract class BaseAppService<TEntity, TEntityViewModel> : IAppServicoBase<TEntity, TEntityViewModel>
        where TEntity : EntityBase
        where TEntityViewModel : ViewModelBase
    {
        protected readonly IServiceBase<TEntity> _service;
        protected readonly IMapper iMapper;

        public BaseAppService(IMapper iMapper, IServiceBase<TEntity> servico)
            : base()
        {
            this.iMapper = iMapper;
            this._service = servico;
        }

        public TEntityViewModel Alterar(TEntityViewModel entidade)
        {
            //return _service.Update(iMapper.Map<TEntity>(entidade));
            return iMapper.Map<TEntityViewModel>(_service.Update(iMapper.Map<TEntity>(entidade)));
        }

        public void Excluir(int id)
        {
            _service.Remove(id);
        }

        public void Excluir(TEntityViewModel entidade)
        {
            _service.Excluir(iMapper.Map<TEntity>(entidade));
        }

        public IEnumerable<TEntityViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<TEntityViewModel> GetAllHistory(Guid id)
        {
            throw new NotImplementedException();
        }

        public TEntityViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Register(TEntityViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntityViewModel customerViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
