using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Domain.Services
{
    public class EdificacoesMoradoresServico : BaseServico<EdificacoesMoradores>, IEdificacoesMoradoresServico
    {
        protected readonly IEdificacoesMoradoresRepositorio _EdificacoesMoradoresRepositorio;

        public EdificacoesMoradoresServico(IEdificacoesMoradoresRepositorio repositorio) : base(repositorio)
        {
            _EdificacoesMoradoresRepositorio = repositorio;
        }

    }
}
