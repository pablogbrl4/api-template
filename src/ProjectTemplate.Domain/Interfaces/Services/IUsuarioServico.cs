using ProjectTemplate.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Domain.Interfaces.Services
{
    public interface IUsuarioServico : IBaseServico<Usuario>
    {
        Usuario FazerLoginByUsuario(string codUsuario, string senhaUsuario);
    }
}
