using System;
using System.Linq;
using AndcultureCode.CSharp.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.PostgreSQL
{
    public abstract class Context : DbContext, IContext
    {
        protected Context(DbContextOptions<ViniloContext> contextOptions) : base(contextOptions)
        {
        }

        public new void Add<T>(T entity) where T : class => base.Add(entity);

        public virtual void CreateStructure()
        {}

        public virtual void DeleteDatabase()
        {}

        public void Delete<T>(T entity) where T : class
        {
            var set = base.Set<T>();
            set.Remove(entity);
        }

        public void DetectChanges() => base.ChangeTracker.DetectChanges();

        public void DropStructure()
        {}

        public long ExecuteCommand(string commandText) => base.Database.ExecuteSqlRaw(commandText);

        public IQueryable<T> Query<T>() where T : class => base.Set<T>();

        public new void Update<T>(T entity) where T : class => base.Update(entity);
    }
}
