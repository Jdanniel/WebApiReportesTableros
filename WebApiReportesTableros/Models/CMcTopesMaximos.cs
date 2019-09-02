using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CMcTopesMaximos
    {
        public int IdTopeMaximo { get; set; }
        public int? IdViatico { get; set; }
        public string PrecioMaximo { get; set; }
        public string Estatus { get; set; }
    }
}
