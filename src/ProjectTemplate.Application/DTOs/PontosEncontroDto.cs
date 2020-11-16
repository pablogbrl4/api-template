using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectTemplate.Application.DTOs
{
    public class PontosEncontroDto : BaseEntidadeDTO
    {
        public string Name { get; set; }

        public string Nome_Refer { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public double X { get; set; }

        public double Y { get; set; }
    }
}
