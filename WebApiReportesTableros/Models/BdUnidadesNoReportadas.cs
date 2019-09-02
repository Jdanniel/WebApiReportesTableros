using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdUnidadesNoReportadas
    {
        public int IdUnidadNoReportada { get; set; }
        public int IdAuditoriaReporte { get; set; }
        public string NoSerieNoReportado { get; set; }
        public int? IdStatusSerie { get; set; }

        public virtual BdAuditoriaReporte IdAuditoriaReporteNavigation { get; set; }
    }
}
