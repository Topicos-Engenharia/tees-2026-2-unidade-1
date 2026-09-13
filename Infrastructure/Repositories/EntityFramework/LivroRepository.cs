using Core.Datatables;
using Core.DTO;
using Core.Entities;
using Core.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.EntityFramework
{
    public class LivroRepository : BaseRepository<Livro>, ILivroRepository
    {
        public LivroRepository(BibliotecaContext context) : base(context)
        { }

        public IEnumerable<Autor> GetAutoresByLivro(uint idLivro)
        {
            var livro = context.Livros.Where(l => l.Id == idLivro).FirstOrDefault();
            if (livro != null)
                return livro.IdAutors;
            return [];
        }

        public IEnumerable<Livro> GetLivrosByNomeEditora(string nome)
        {
            var query = from livro in context.Livros
                        where livro.IdEditoraNavigation.Nome.StartsWith(nome)
                        select livro;
            return query;
        }

        /// <summary>
        /// Obter dados dos livros ordenado pelo nome que iniciam com um nome
        /// </summary>
        /// <param name="nome">nome a ser buscado</param>
        /// <returns>lista de livros</returns>
        public IEnumerable<LivroDto> GetByNome(string nome)
        {
            var query = from livro in context.Livros
                        where livro.Nome.StartsWith(nome)
                        orderby livro.Nome
                        select new LivroDto
                        {
                            Id = livro.Id,
                            Nome = livro.Nome,
                            Isbn = livro.Isbn,
                            NomeEditora = livro.IdEditoraNavigation.Nome
                        };
            return query;
        }
    }
}
