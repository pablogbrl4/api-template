using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectTemplate.Application.DTOs
{
    public class EdificacoesMoradoresDto : BaseEntidadeDTO
    {
        public string COD_EDIFICACAO { get; set; }
        [ForeignKey("COD_EDIFICACAO")]

        public string UTM_X { get; set; }

        public string UTM_Y { get; set; }

        public string LAT { get; set; }

        public string LONG_ { get; set; }

        public string IDENT_GLOBAL { get; set; }

        public string RELACAO { get; set; }

        public string NOME { get; set; }

        public string RELACAO_FAMILIAR { get; set; }

        public string TELEFONE { get; set; }

        public string SEXO { get; set; }

        public string IDADE { get; set; }

        public string PONTO_ENCONTRO { get; set; }
    }
}
