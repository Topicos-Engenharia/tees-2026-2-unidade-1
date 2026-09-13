using Core.DTO;
using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Service;

namespace Service
{
    /// <summary>
    /// Implementa serviços para manter os dados do item do acervo
    /// </summary>
    public class ItemAcervoService : BaseService<Itemacervo>, IItemAcervoService
    {
        private readonly IItemAcervoRepository itemAcervoRepository;

        public ItemAcervoService(IItemAcervoRepository itemAcervoRepository) : base(itemAcervoRepository)
        {
            this.itemAcervoRepository = itemAcervoRepository;
        }


        /// <summary>
        /// Obter todos os itens do acervo cadastrados
        /// </summary>
        /// <returns>todos os itens acervo</returns>
        public new IEnumerable<ItemAcervoDto> GetAll()
        {
            return itemAcervoRepository.GetAll();
        }
    }
}
