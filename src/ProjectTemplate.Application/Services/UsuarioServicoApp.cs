using AutoMapper;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Application.Interfaces;
using ProjectTemplate.Domain.Entities;
using ProjectTemplate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectTemplate.Application.Services
{
    public class UsuarioServicoApp: BaseServicoApp<Usuario, UsuarioDto>, IUsuarioApp
    {
        protected readonly IUsuarioServico _usuarioServico;

        public UsuarioServicoApp(IUsuarioServico usuarioServico, IMapper mapper) : base (usuarioServico, mapper)
        {
            _usuarioServico = usuarioServico;
        }

        public UsuarioDto FazerLoginByUsuario(string codUsuario, string senhaUsuario)
        {
            var usuario = _usuarioServico.FazerLoginByUsuario(codUsuario, senhaUsuario);

            return _mapper.Map<UsuarioDto>(usuario);
        }

    }
}
