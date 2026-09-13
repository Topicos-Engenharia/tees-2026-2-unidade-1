using Core.Datatables;
using Core.DTO;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Service;

namespace Service
{
    /// <summary>
    /// Implementa serviços para manter dados do autor
    /// </summary>
    public class AutorService : BaseService<Autor>, IAutorService
    {
        private readonly IAutorRepository autorRepository;

        public AutorService(IAutorRepository autorRepository) : base(autorRepository)
        {
            this.autorRepository = autorRepository;
        }

        public IEnumerable<Autor> GetAllOrderByNome()
        {
            return autorRepository.GetAllOrderByNome();


            //return context.Autors.
            //    OrderByDescending(autor => autor.Nome).
            //    AsNoTracking();
        }

        public int GetCountAutores()
        {
            return autorRepository.GetCountAutores();
        }

        public IEnumerable<Autor> GetOrderByDescending()
        {
            return autorRepository.GetOrderByDescending();
        }


        /// <summary>
        /// Buscar autores iniciando com o nome
        /// </summary>
        /// <param name="nome">nome do autor</param>
        /// <returns>lista de autores que inicia com o nome</returns>
        public IEnumerable<AutorDto> GetByNome(string nome)
        {
            return autorRepository.GetByNome(nome);
        }

        /// <summary>
        /// Retorna uma página de dados
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public DatatableResponse<Autor> GetDataPage(DatatableRequest request)
        {
            return autorRepository.GetDataPage(request);

        }
    }
}
