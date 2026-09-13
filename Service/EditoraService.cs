using Core.DTO;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Service;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    /// <summary>
    /// Implementa os serviços para manter os dados de editoras
    /// </summary>
    public class EditoraService : BaseService<Editora>, IEditoraService
    {

        private readonly IEditoraRepository editoraRepository;

        public EditoraService(IEditoraRepository editoraRepository) : base(editoraRepository)
        {
            this.editoraRepository = editoraRepository;
        }
        /// <summary>
        /// Obter editoras que iniciam com o nome
        /// </summary>
        /// <param name="nome">nome da editora</param>
        /// <returns>lista de editoras</returns>
        public IEnumerable<Editora> GetByNome(string nome)
        {
            return editoraRepository.GetByNome(nome);
        }


        public IEnumerable<Editora> GetByEstados()
        {
            return editoraRepository.GetByEstados();
        }
    }
}
