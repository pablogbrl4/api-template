﻿using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Application.Interfaces
{
    public interface IUsuarioApp : IBaseApp<Usuario, UsuarioDto>
    {
        UsuarioDto FazerLoginByUsuario(string codUsuario, string senhaUsuario);
    }
}
