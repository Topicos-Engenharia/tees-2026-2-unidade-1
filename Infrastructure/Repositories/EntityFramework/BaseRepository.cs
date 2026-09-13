using Core.Interfaces.Entity;
using Core.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.EntityFramework
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly BibliotecaContext context;
        protected readonly DbSet<TEntity> dbSet;

        public BaseRepository(BibliotecaContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual uint Create(TEntity entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }
        public virtual void Update(TEntity entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }

        public virtual void Delete(uint id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                context.SaveChanges();
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public virtual TEntity? GetById(uint id)
        {
            return dbSet.Find(id);
        }
    }
}
