using System;
using System.Linq;
using StarWars.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using StarWars.Domain.Entities;

namespace StarWars.Infra.Data.Context
{
    public class StarWarsContext : DbContext
    {
        public DbSet<Starship> Starship { get; set; }

        public IDbContextTransaction Transaction { get; private set; }

        public StarWarsContext(DbContextOptions<StarWarsContext> options)
            : base(options)
        {
            //if (Database.GetPendingMigrations().Count() > 0)
            //    Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration(new StarshipMap());
        }

        public IDbContextTransaction InitTransacao()
        {
            if (Transaction == null) Transaction = Database.BeginTransaction();
            return Transaction;
        }

        private void RollBack()
        {
            if (Transaction != null)
            {
                Transaction.Rollback();
            }
        }

        private void Salvar()
        {
            try
            {
                ChangeTracker.DetectChanges();
                SaveChanges();
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            if (Transaction != null)
            {
                Transaction.Commit();
                Transaction.Dispose();
                Transaction = null;
            }
        }

        public void SendChanges()
        {
            Salvar();
            Commit();
        }        

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Created") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("Created").CurrentValue = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Property("Created").IsModified = false;
                }
             };

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("LastModified") != null))
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("LastModified").CurrentValue = DateTime.Now;
                }
                else if (entry.State == EntityState.Added)
                {
                    entry.Property("LastModified").IsModified = false;
                }
            };

            return base.SaveChanges();
        }
    }
}
