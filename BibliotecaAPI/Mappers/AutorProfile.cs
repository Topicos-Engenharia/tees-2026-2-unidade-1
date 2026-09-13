using AutoMapper;
using BibliotecaAPI.Models;
using Core.Entities;

namespace BibliotecaAPI.Mappers
{
    public class AutorProfile : Profile
    {
        public AutorProfile()
        {
            CreateMap<AutorViewModel, Autor>().ReverseMap();
        }
    }
}
