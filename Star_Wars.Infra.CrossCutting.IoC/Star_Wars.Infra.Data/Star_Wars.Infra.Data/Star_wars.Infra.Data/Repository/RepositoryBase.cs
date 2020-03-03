using System;
using System.Collections.Generic;
using System.Linq;
using Star_Wars.Domain.Common;
using Star_Wars.Domain.Interfaces.Repositories;
using Star_Wars.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Star_Wars.Infra.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected readonly Star_WarsContext _contexto;

        public RepositoryBase(Star_WarsContext context)
            : base()
        {
            _contexto = context;
        }


        public virtual TEntity GetById(Guid id)
        {
            return _contexto.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _contexto.Set<TEntity>().ToList();
        }

        public virtual TEntity Update(TEntity entidade)
        {
            _contexto.InitTransacao();
            _contexto.Set<TEntity>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SendChanges();
            return entidade;
        }

        public virtual void Remove(int id)
        {
            var entidade = _contexto.Set<TEntity>().Find(id);
            if (entidade != null)
            {
                _contexto.InitTransacao();
                _contexto.Set<TEntity>().Remove(entidade);
                _contexto.SendChanges();
            }
        }
        public virtual void Remove(TEntity entidade)
        {
            _contexto.InitTransacao();
            _contexto.Set<TEntity>().Remove(entidade);
            _contexto.SendChanges();
        }
        public virtual TEntity SaveChanges(TEntity entidade)
        {
            _contexto.InitTransacao();
            _contexto.Set<TEntity>().Add(entidade);
            _contexto.SendChanges();
            return entidade;
        }

        public void Dispose()
        {
            _contexto.Dispose();
            GC.SuppressFinalize(this);
        }

        TEntity IRepositoryBase<TEntity>.Add(TEntity entidade)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
