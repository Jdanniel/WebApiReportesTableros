using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdProactivas
    {
        public int IdProactiva { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Week { get; set; }
        public string NoAfiliacion { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuario { get; set; }
        public string Estatus { get; set; }
    }
}
