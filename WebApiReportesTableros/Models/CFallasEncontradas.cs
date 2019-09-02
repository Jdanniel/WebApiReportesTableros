using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CFallasEncontradas
    {
        public int IdFalla { get; set; }
        public string DescFalla { get; set; }
        public int? IdCliente { get; set; }
        public string Status { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
