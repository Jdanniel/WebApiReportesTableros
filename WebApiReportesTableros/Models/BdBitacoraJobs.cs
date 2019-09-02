using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdBitacoraJobs
    {
        public int IdBitacoraJob { get; set; }
        public string JobName { get; set; }
        public DateTime? Fecha { get; set; }
        public string Status { get; set; }
    }
}
