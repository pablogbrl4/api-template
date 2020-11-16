using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectTemplate.Infra.Data.Repositories
{
    public class EdificacoesRepositorio : BaseRepositorio<Edificacoes>, IEdificacoesRepositorio
    {
        public EdificacoesRepositorio(BaseContexto context) : base(context)
        {
        }

    }
}
