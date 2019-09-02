using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdArCausasCancelacion
    {
        public int IdArCausaCancelacion { get; set; }
        public int? IdAr { get; set; }
        public int? IdCausaCancelacion { get; set; }
    }
}
