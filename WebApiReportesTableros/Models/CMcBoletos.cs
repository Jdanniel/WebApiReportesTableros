﻿using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CMcBoletos
    {
        public int IdBoleto { get; set; }
        public string DescNombre { get; set; }
        public string Costo { get; set; }
        public string Estatus { get; set; }
    }
}
