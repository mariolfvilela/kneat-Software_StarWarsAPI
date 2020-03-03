using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWars.Domain.Common;
using StarWars.Domain.Interfaces.Repositories;
using Star_Wars.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Star_Wars.Infra.Data.Repository
{
    
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected readonly Star_WarsContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(Star_WarsContext contexto)
            : base()
        {
            _context = contexto;
            DbSet = _context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual int Add(TEntity entidade)
        {
            _context.InitTransacao();
            int id = DbSet.Add(entidade).Entity.Id;
            _context.SendChanges();
            //DbSet.Add(entidade);
            return id;
        }

        public virtual void RemoveById(int id)
        {
            var entidade = GetById(id);
            if (entidade != null)
            {
                _context.InitTransacao();
                DbSet.Remove(entidade);
                _context.SendChanges();
            }
        }

        public virtual void Remove(TEntity entidade)
        {
            _context.InitTransacao();
            DbSet.Remove(entidade);
            _context.SendChanges();
        }

        public virtual TEntity Update(TEntity entidade)
        {
            _context.InitTransacao();
            DbSet.Attach(entidade);
            _context.Entry(entidade).State = EntityState.Modified;
            _context.SendChanges();
            return entidade;
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }


        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> ListAsync()
        {
            return await DbSet.ToListAsync();
        }
    }
}
