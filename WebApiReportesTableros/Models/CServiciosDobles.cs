using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CServiciosDobles
    {
        public int IdServicioDoble { get; set; }
        public int? IdFalla { get; set; }
        public int? IdServicio { get; set; }
        public int? Outblue { get; set; }
        public int? RollosProductivo { get; set; }
    }
}
