using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdPasoArNumber
    {
        public int IdPaso { get; set; }
        public int? IdAr { get; set; }
        public int? IdStatus { get; set; }
        public int? Number { get; set; }
        public string Status { get; set; }
    }
}
