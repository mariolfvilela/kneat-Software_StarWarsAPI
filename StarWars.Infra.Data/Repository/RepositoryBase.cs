using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StarWars.Domain.Common;
using StarWars.Domain.Interfaces.Repositories;
using StarWars.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace StarWars.Infra.Data.Repository
{
    
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory
        /// InMemory
        /// </summary>
        

        protected readonly StarWarsContext _context;
        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(StarWarsContext contexto)
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
            int id = DbSet.Add(entidade).Entity.Id;
            // _context.SaveChangesAsync();
            SaveChanges();
            return id;
        }

        public virtual void RemoveById(int id)
        {
            var entidade = GetById(id);
            if (entidade != null)
            {
                DbSet.Remove(entidade);
                //_context.SaveChangesAsync();
                SaveChanges();
            }
        }

        public virtual void Remove(TEntity entidade)
        {
            DbSet.Remove(entidade);
            //_context.SaveChangesAsync();
            SaveChanges();
        }

        public virtual TEntity Update(TEntity entidade)
        {
            DbSet.Attach(entidade);
            _context.Entry(entidade).State = EntityState.Modified;
            //_context.SaveChangesAsync();
            SaveChanges();
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
            return await DbSet.AsNoTracking().ToListAsync();
        }
    }
}
