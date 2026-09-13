using Core.DTO;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Service;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class LivroService : BaseService<Livro>, ILivroService
    {
        private readonly ILivroRepository livroRepository;

        public LivroService(ILivroRepository livroRepository) : base(livroRepository)
        {
            this.livroRepository = livroRepository;
        }

        public IEnumerable<Autor> GetAutoresByLivro(uint idLivro)
        {
            return livroRepository.GetAutoresByLivro(idLivro);
        }

        public IEnumerable<Livro> GetLivrosByNomeEditora(string nome)
        {
            return livroRepository.GetLivrosByNomeEditora(nome);
        }

        /// <summary>
        /// Obter dados dos livros ordenado pelo nome que iniciam com um nome
        /// </summary>
        /// <param name="nome">nome a ser buscado</param>
        /// <returns>lista de livros</returns>
        public IEnumerable<LivroDto> GetByNome(string nome)
        {
            return livroRepository.GetByNome(nome);
        }
    }
}
