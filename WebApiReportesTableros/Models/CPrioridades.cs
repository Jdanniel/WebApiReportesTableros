using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CPrioridades
    {
        public int IdPrioridades { get; set; }
        public string DescPrioridades { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public string Status { get; set; }
        public DateTime? FecAlta { get; set; }
    }
}
