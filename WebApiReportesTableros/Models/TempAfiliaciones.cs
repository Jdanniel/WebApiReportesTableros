using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class TempAfiliaciones
    {
        public int IdTempAfilacion { get; set; }
        public string NoAfiliacion { get; set; }
        public int? IdCliente { get; set; }
        public string IdResponsable { get; set; }
    }
}
