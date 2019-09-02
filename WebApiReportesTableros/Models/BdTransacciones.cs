using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdTransacciones
    {
        public int IdTransacciones { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int NoFiliacion { get; set; }
        public int ApprovedcCount { get; set; }
        public int Declinedcount { get; set; }
    }
}
