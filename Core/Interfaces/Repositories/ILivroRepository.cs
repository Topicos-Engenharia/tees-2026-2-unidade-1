using Core.DTO;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface ILivroRepository : IBaseRepository<Livro>
    {
        IEnumerable<LivroDto> GetByNome(string nome);

        IEnumerable<Autor> GetAutoresByLivro(uint idLivro);

        IEnumerable<Livro> GetLivrosByNomeEditora(string nome);
    }
}
