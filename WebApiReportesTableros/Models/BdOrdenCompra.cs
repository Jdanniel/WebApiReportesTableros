using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdOrdenCompra
    {
        public int IdOrdenCompra { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public int? IdStatusOrdenCompra { get; set; }
        public DateTime? FecOrdenCompra { get; set; }
    }
}
