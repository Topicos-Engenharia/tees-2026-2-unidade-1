using Core.DTO;
using Core.Entities;

namespace Core.Interfaces.Service
{
    public interface ILivroService : IBaseService<Livro>
    {
        IEnumerable<LivroDto> GetByNome(string nome);

        IEnumerable<Autor> GetAutoresByLivro(uint idLivro);

        IEnumerable<Livro> GetLivrosByNomeEditora(string nome);
    }
}
