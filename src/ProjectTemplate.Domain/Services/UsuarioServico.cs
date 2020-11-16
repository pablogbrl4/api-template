using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Domain.Services
{
    public class UsuarioServico : BaseServico<Usuario>, IUsuarioServico
    {
        protected readonly IUsuarioRepositorio _UsuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio repositorio) : base(repositorio)
        {
            _UsuarioRepositorio = repositorio;
        }

        public Usuario FazerLoginByUsuario(string codUsuario, string senhaUsuario)
        {
            return _UsuarioRepositorio.FazerLoginByUsuario(codUsuario, senhaUsuario);
        }
    }
}
