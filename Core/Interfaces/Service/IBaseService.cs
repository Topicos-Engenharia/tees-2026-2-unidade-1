using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    public interface IBaseService<TEntity>
    {
        uint Create(TEntity entidade);
        void Edit(TEntity entidade);
        void Delete(uint id);
        TEntity? Get(uint id);
        IEnumerable<TEntity> GetAll();
    }
}
