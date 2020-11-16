using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTemplate.Infra.Data.Repositories
{
    public class PontosEncontroRepositorio : BaseRepositorio<PontosEncontro>, IPontosEncontroRepositorio
    {
        public PontosEncontroRepositorio(BaseContexto context) : base(context)
        {
        }

    }
}
