using AutoMapper;
using BibliotecaWeb.Models;
using Core.Entities;

namespace BibliotecaWeb.Mappers
{
    public class AutorProfile : Profile
    {
        public AutorProfile()
        {
            CreateMap<AutorViewModel, Autor>().ReverseMap();
        }
    }
}
