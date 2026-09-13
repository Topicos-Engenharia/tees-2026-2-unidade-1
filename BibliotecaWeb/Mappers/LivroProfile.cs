using AutoMapper;
using BibliotecaWeb.Models;
using Core.Entities;

namespace BibliotecaWeb.Mappers
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<LivroViewModel, Livro>().ReverseMap();

        }
    }
}
