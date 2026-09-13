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
    public class EditoraRepository : BaseRepository<Editora>, IEditoraRepository
    {
        public EditoraRepository(BibliotecaContext context) : base(context)
        { }

        public IEnumerable<Editora> GetByNome(string nome)
        {
            var query = from editora in context.Editoras
                        where editora.Nome.StartsWith(nome)
                        orderby editora.Nome
                        select editora;
            return query.AsNoTracking();
        }


        public IEnumerable<Editora> GetByEstados()
        {
            return context.Editoras.Where(
                editora => editora.Nome.Contains("Editora") &&
                (editora.Estado.Equals("SP") ||
                 editora.Estado.Equals("RS")));

            //var query = from editora in context.Editoras
            //            where editora.Nome.Contains("Editora") &&
            //                (editora.Estado.Equals("SP") ||
            //                editora.Estado.Equals("RS"))
            //             select editora;
            // return query.AsNoTracking();
        }


    }
}
