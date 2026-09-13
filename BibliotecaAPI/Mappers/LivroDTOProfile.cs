using AutoMapper;
using BibliotecaAPI.Models;
using Core.DTO;

namespace BibliotecaAPI.Mappers
{
    public class LivroDTOProfile : Profile
    {
        public LivroDTOProfile()
        {
            CreateMap<LivroViewModel, LivroDto>().ReverseMap();

        }
    }
}
