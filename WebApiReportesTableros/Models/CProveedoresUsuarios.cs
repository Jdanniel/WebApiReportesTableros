using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CProveedoresUsuarios
    {
        public int IdProveedorUsuario { get; set; }
        public string DescProveedorUsuario { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
    }
}
