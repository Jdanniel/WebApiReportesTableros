using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class SiBdLog
    {
        public int IdLog { get; set; }
        public int? IdServicio { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Responsable { get; set; }
        public string EstadoServicio { get; set; }
        public string Descripcion { get; set; }
    }
}
