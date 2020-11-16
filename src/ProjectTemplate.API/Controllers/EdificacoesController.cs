using Microsoft.AspNetCore.Mvc;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Application.Interfaces;
using System;

namespace ProjectTemplate.API.Controllers
{
    public class EdificacoesController : CoreController<Edificacoes, EdificacoesDto>
    {

        protected readonly IEdificacoesApp _edificacoesApp;

        public EdificacoesController(IEdificacoesApp edificacoesController) : base(edificacoesController)
        {
            _edificacoesApp = edificacoesController;
        }

    }
}
