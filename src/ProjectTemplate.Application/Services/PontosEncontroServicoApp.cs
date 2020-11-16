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
    public class PontosEncontroServicoApp : BaseServicoApp<PontosEncontro, PontosEncontroDto>, IPontosEncontroApp
    {
        protected readonly IPontosEncontroServico _pontosEncontroServico;

        public PontosEncontroServicoApp(IPontosEncontroServico pontosEncontroServico, IMapper mapper) : base (pontosEncontroServico, mapper)
        {
            _pontosEncontroServico = pontosEncontroServico;
        }



    }
}
