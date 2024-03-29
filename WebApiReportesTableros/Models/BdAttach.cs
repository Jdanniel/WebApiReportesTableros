﻿using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdAttach
    {
        public BdAttach()
        {
            BdFotoAr = new HashSet<BdFotoAr>();
        }

        public int IdAttach { get; set; }
        public int? IdTipoArchivo { get; set; }
        public string DescAttach { get; set; }
        public string SystemFilename { get; set; }
        public string UserFilename { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdUsuarioAlta { get; set; }

        public virtual ICollection<BdFotoAr> BdFotoAr { get; set; }
    }
}
