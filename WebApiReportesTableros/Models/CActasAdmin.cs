using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CActasAdmin
    {
        public int IdTipoActaAdmin { get; set; }
        public string DescActaAdmin { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
    }
}
