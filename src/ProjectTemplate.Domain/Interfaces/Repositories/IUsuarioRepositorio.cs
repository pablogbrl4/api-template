using ProjectTemplate.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario FazerLoginByUsuario(string codUsuario, string senhaUsuario);

    }
}
