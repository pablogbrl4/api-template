using ProjectTemplate.Domain.Entities;


namespace ProjectTemplate.Application.DTOs
{
    public class Edificacoes : BaseEntidade
    {

        public string COD_EDIFICACAO { get; set; }

        public string UTM_X { get; set; }

        public string UTM_Y { get; set; }

        public string LAT { get; set; }

        public string LONG { get; set; }

        public string IDENT_GLOBAL { get; set; }

        public string TIPO_LOGRADOURO { get; set; }

        public string NOME_LOGRADOURO { get; set; }

        public string NUMERO { get; set; }

        public string COMPLEMENTO { get; set; }

        public string BAIRRO { get; set; }

        public string LOCALIDADE { get; set; }

        public string N_RESIDENTES { get; set; }

        public string FUNCIONARIOS { get; set; }

        public string PONTO_ENCONTRO { get; set; }
    }
}
