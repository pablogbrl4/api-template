using Microsoft.AspNetCore.Mvc;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Application.Interfaces;
using System;

namespace ProjectTemplate.API.Controllers
{
    public class EdificacoesMoradoresController : CoreController<EdificacoesMoradores, EdificacoesMoradoresDto>
    {

        protected readonly IEdificacoesMoradoresApp _edificacoesMoradoresApp;

        public EdificacoesMoradoresController(IEdificacoesMoradoresApp edificacoesMoradores) : base(edificacoesMoradores)
        {
            _edificacoesMoradoresApp = edificacoesMoradores;
        }

    }
}
