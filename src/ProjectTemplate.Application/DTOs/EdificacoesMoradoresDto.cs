using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Application.DTOs
{
    public class EdificacoesMoradoresDto : BaseEntidadeDTO
    {
        public string COD_EDIFICACAO { get; set; }

        public string UTM_X { get; set; }

        public double UTM_Y { get; set; }

        public double LAT { get; set; }

        public double LONG_ { get; set; }

        public double IDENT_GLOBAL { get; set; }

        public double RELACAO { get; set; }

        public double NOME { get; set; }

        public double RELACAO_FAMILIAR { get; set; }

        public double TELEFONE { get; set; }

        public double SEXO { get; set; }

        public double IDADE { get; set; }

        public double PONTO_ENCONTRO { get; set; }
    }
}
