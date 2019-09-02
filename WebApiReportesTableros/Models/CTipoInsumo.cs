using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class CTipoInsumo
    {
        public CTipoInsumo()
        {
            CInsumosOld = new HashSet<CInsumosOld>();
        }

        public int IdTipoInsumo { get; set; }
        public string DescTipoInsumo { get; set; }
        public string Status { get; set; }

        public virtual ICollection<CInsumosOld> CInsumosOld { get; set; }
    }
}
