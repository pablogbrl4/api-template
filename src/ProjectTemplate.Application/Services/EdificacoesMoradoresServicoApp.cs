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
    public class EdificacoesMoradoresServicoApp: BaseServicoApp<EdificacoesMoradores, EdificacoesMoradoresDto>, IEdificacoesMoradoresApp
    {
        protected readonly IEdificacoesMoradoresServico _edificacoesMoradoresServico;

        public EdificacoesMoradoresServicoApp(IEdificacoesMoradoresServico edificacoesMoradoresServico, IMapper mapper) : base (edificacoesMoradoresServico, mapper)
        {
            _edificacoesMoradoresServico = edificacoesMoradoresServico;
        }


    }
}
