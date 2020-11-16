using Microsoft.AspNetCore.Mvc;
using ProjectTemplate.Application.DTOs;
using ProjectTemplate.Application.Interfaces;
using System;

namespace ProjectTemplate.API.Controllers
{
    public class UsuarioController : CoreController<Usuario, UsuarioDto>
    {

        protected readonly IUsuarioApp _usuarioApp;

        public UsuarioController(IUsuarioApp usuario) : base(usuario)
        {
            _usuarioApp = usuario;
        }


        [HttpGet]
        [Route("LoginByUsuario")]
        public IActionResult FazerLoginByNomeUsuario(string codUsuario, string senhaUsuario)
        {
            try
            {
                var objById = _usuarioApp.FazerLoginByUsuario(codUsuario, senhaUsuario);

                if (objById != null)
                {
                    return Ok(true);
                }

                return Ok(false);

                //return new OkObjectResult(objById);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
