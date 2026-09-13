using Core.Interfaces.Entity;
using Core.Interfaces.Repositories;
using Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IBaseRepository<TEntity> repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual uint Create(TEntity entity)
        {
            return repository.Create(entity);
        }

        public virtual TEntity Get(uint id)
        {
            return repository.GetById(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public virtual void Edit(TEntity entity)
        {
            repository.Update(entity);
        }

        public virtual void Delete(uint id)
        {
            repository.Delete(id);
        }
    }
}
