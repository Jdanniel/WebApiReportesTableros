﻿using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CLogros
    {
        public int IdTipoLogro { get; set; }
        public string DescLogro { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
    }
}
