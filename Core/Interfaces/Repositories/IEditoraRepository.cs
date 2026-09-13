using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IEditoraRepository : IBaseRepository<Editora>
    {
        public IEnumerable<Editora> GetByNome(string nome);

        public IEnumerable<Editora> GetByEstados();
    }
}
