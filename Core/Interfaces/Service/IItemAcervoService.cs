using Core.DTO;
using Core.Entities;

namespace Core.Interfaces.Service
{
    public interface IItemAcervoService : IBaseService<Itemacervo>
    {
        IEnumerable<ItemAcervoDto> GetAll();
    }
}
