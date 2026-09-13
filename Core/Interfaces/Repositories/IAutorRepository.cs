using Core.Datatables;
using Core.DTO;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IAutorRepository : IBaseRepository<Autor>
    {
        IEnumerable<Autor> GetAllOrderByNome();

        int GetCountAutores();

        IEnumerable<AutorDto> GetByNome(string nome);

        IEnumerable<Autor> GetOrderByDescending();

        DatatableResponse<Autor> GetDataPage(DatatableRequest request);
    }
}
