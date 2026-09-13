using Core.Datatables;
using Core.DTO;
using Core.Entities;

namespace Core.Interfaces.Service
{
    public interface IAutorService : IBaseService<Autor>
    {
        IEnumerable<AutorDto> GetByNome(string nome);
        DatatableResponse<Autor> GetDataPage(DatatableRequest request);
    }
}
