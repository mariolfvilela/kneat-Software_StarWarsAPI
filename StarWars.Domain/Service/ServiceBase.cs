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
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        protected readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repositorio)
        {
            this._repository = repositorio;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
        public async Task<int> AddAsync(TEntity entidade)
        {
            int id = _repository.Add(entidade);

            return id;
        }

        public async Task<bool> RemoveAsync(TEntity entidade)
        {
            _repository.Remove(entidade);

            return true;
        }

        public async Task<bool> RemoveByIdAsync(int id)
        {
            _repository.RemoveById(id);

            return true;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> ListAsync()
        {
            return await _repository.ListAsync();
        }


        public async Task<TEntity> UpdateAsync(TEntity entidade)
        {
            _repository.Update(entidade);

            return entidade;
        }
    }
}
