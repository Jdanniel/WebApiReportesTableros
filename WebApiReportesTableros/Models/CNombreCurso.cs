﻿using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CNombreCurso
    {
        public int IdNombreCurso { get; set; }
        public string NombreCurso { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public string Status { get; set; }
    }
}
