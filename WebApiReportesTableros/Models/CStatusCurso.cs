﻿using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CStatusCurso
    {
        public int IdStatusCurso { get; set; }
        public string StatusCurso { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
    }
}
