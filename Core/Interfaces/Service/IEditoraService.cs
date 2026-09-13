using Core.Entities;

namespace Core.Interfaces.Service
{
    public interface IEditoraService : IBaseService<Editora>
    {
        IEnumerable<Editora> GetByNome(string nome);

        IEnumerable<Editora> GetByEstados();
    }
}
