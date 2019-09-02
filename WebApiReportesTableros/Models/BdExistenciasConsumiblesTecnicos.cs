using System;
using System.Collections.Generic;

namespace WebApiReportesTableros.Models
{
    public partial class BdExistenciasConsumiblesTecnicos
    {
        public int IdExistenciaConsumibleTecnico { get; set; }
        public int IdTecnico { get; set; }
        public int IdConsumible { get; set; }
        public int? ConsumiblesRecibidos { get; set; }
        public int? ConsumiblesReportados { get; set; }
    }
}
