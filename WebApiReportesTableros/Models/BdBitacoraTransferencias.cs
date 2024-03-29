﻿using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdBitacoraTransferencias
    {
        public int IdBitacoraTransferencia { get; set; }
        public int? IdUnidad { get; set; }
        public int? IdTipoResponsableAnterior { get; set; }
        public int? IdResponsableAnterior { get; set; }
        public int? IdTipoResponsableActual { get; set; }
        public int? IdResponsableActual { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Comentarios { get; set; }
    }
}
