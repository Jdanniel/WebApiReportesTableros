using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CTipoLocalidad
    {
        public int IdTipoLocalidad { get; set; }
        public string DescLocalidad { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public string Status { get; set; }
    }
}
