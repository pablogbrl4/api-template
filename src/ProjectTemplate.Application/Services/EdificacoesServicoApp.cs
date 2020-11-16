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
    public class EdificacoesServicoApp: BaseServicoApp<Edificacoes, EdificacoesDto>, IEdificacoesApp
    {
        protected readonly IEdificacoesServico _edificacoesServico;

        public EdificacoesServicoApp(IEdificacoesServico edificacoesServico, IMapper mapper) : base (edificacoesServico, mapper)
        {
            _edificacoesServico = edificacoesServico;
        }

    }
}
