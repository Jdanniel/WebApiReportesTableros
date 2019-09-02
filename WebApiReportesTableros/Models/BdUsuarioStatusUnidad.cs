using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdUsuarioStatusUnidad
    {
        public int IdUsuarioStatusUnidad { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdStatus { get; set; }
        public int? IsChecked { get; set; }
    }
}
