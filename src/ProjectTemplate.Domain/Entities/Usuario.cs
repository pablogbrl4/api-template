using ProjectTemplate.Domain.Entities;


namespace ProjectTemplate.Application.DTOs
{
    public class Usuario : BaseEntidade
    {

        public string CodUsuario { get; set; }

        public string SenhaUsuario { get; set; }
    }
}
