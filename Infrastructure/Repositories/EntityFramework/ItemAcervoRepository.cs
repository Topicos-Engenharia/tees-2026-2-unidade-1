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
    public class ItemAcervoRepository : BaseRepository<Itemacervo>, IItemAcervoRepository
    {
        public ItemAcervoRepository(BibliotecaContext context) : base(context)
        { }

         public new IEnumerable<ItemAcervoDto> GetAll()
        {
            var query = from itemAcervo in context.Itemacervos
                        orderby itemAcervo.IdLivroNavigation.Nome descending
                        select new ItemAcervoDto
                        {
                            Id = itemAcervo.Id,
                            NomeLivro = itemAcervo.IdLivroNavigation.Nome,
                            NomeBiblioteca = itemAcervo.IdBibliotecaNavigation.Nome,
                            SituacaoItemAcervo = itemAcervo.IdSituacaoItemAcervoNavigation.Situacao
                        };
            return query;
        }


    }
}
