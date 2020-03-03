using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWars.Domain.Common;
using StarWars.Domain.Exceptions;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Domain.Interfaces.Services;

namespace StarWars.Domain.Service
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        protected readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repositorio)
        {
            this._repository = repositorio;
        }

        public TEntity Add(TEntity entidade)
        {
            throw new NotImplementedException();
        }

        

        public void Dispose()
        {
            _repository.Dispose();
        }

        public void Excluir(TEntity entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual TEntity GetById(int id)
        {
            var entidade = _repository.GetById(id);

            if (entidade == null)
            {
                throw new Exception("no find");
            }

            return entidade;
        }

       

        public Task<IEnumerable<TEntity>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(int id)
        {
            _repository.RemoveById(id);
        }

        

        public virtual IEnumerable<TEntity> SelecionarTodos()
        {
            var entidades = _repository.GetAll();

            if (!entidades.Any())
            {
                throw new Exception("No find");
            }

            return entidades;
        }

        public TEntity Update(TEntity entidade)
        {
            throw new NotImplementedException();
        }
    }
}
