using Microsoft.AspNetCore.Mvc;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Application.Interfaces;
using ProjectTemplate.Domain.Entities;
using System;

namespace ProjectTemplate.API.Controllers
{
    public class PontosEncontroController : CoreController<PontosEncontro, PontosEncontroDto>
    {

        protected readonly IPontosEncontroApp _pontosEncontroApp;

        public PontosEncontroController(IPontosEncontroApp pontosEncontro) : base(pontosEncontro)
        {
            _pontosEncontroApp = pontosEncontro;
        }

    }
}
