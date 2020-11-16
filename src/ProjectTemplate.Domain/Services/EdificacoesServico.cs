using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Domain.Services
{
    public class EdificacoesServico : BaseServico<Edificacoes>, IEdificacoesServico
    {
        protected readonly IEdificacoesRepositorio _EdificacoesRepositorio;

        public EdificacoesServico(IEdificacoesRepositorio repositorio) : base(repositorio)
        {
            _EdificacoesRepositorio = repositorio;
        }

    }
}
