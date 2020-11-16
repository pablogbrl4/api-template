using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTemplate.Application.DTOs
{
    public class UsuarioDto : BaseEntidadeDTO
    {

        [Required]
        public string CodUsuario { get; set; }

        [Required]
        public string SenhaUsuario { get; set; }

    }
}
