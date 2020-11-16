using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Domain.Interfaces.Repositories;
using ProjectTemplate.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Domain.Services
{
    public class PontosEncontroServico : BaseServico<PontosEncontro>, IPontosEncontroServico
    {
        protected readonly IPontosEncontroRepositorio _PontosEncontroRepositorio;

        public PontosEncontroServico(IPontosEncontroRepositorio repositorio) : base(repositorio)
        {
            _PontosEncontroRepositorio = repositorio;
        }

    }
}
