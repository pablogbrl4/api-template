using AutoMapper;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Entities;

namespace ProjectTemplate.Application.Mappings
{
    public class BaseMapping : Profile
    {
        public BaseMapping()
        {
            CreateMap<Usuario, UsuarioDto>().ReverseMap();

            CreateMap<Edificacoes, EdificacoesDto>().ReverseMap();

            CreateMap<EdificacoesMoradores, EdificacoesMoradoresDto>().ReverseMap();

            CreateMap<PontosEncontro, PontosEncontroDto>().ReverseMap();
        }
    }
}
