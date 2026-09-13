using AutoMapper;
using BibliotecaWeb.Models;
using Core.Entities;

namespace BibliotecaWeb.Mappers
{
    public class EditoraProfile : Profile
    {
        public EditoraProfile()
        {
            CreateMap<EditoraViewModel, Editora>().ReverseMap();
        }
    }
}
