using AutoMapper;
using BibliotecaAPI.Models;
using Core.Entities;

namespace BibliotecaAPI.Mappers
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<LivroViewModel, Livro>().ReverseMap();

        }
    }
}
