using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdDirectorioTelefonicoAr
    {
        public int IdDirectorioTelefonicoAr { get; set; }
        public string Telefono { get; set; }
        public int? IdAr { get; set; }
        public int? UsuarioAlta { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
