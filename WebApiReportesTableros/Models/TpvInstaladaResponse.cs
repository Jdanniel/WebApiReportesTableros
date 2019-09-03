using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiReportesTableros.Models
{
    public class TpvInstaladaResponse
    {
        public int ID_SERVICIO { get; set; }
        public string DESC_FALLA { get; set; }
        public string DESC_SERVICIO { get; set; }
        public int ID_AR { get; set; }
        public string NO_AR { get; set; }
        public string NO_AFILIACION { get; set; }
        public string DESC_NEGOCIO { get; set; }
        public string NO_SIM_AR { get; set; }
        public string CADENA_CIERRE { get; set; }
        public string DESC_MODELO { get; set; }
        public string DESC_STATUS_UNIDAD { get; set; }
        public string NO_SERIE { get; set; }
        public string NO_SIM_UNIDADES { get; set; }
        public string CAJA { get; set; }
        public DateTime? FEC_CIERRE { get; set; }
        public int IS_DANIADA { get; set; }
        public DateTime? FEC_STATUS { get; set; }
        public string DESC_CONECTIVIDAD { get; set; }
        public string DESC_SOFTWARE { get; set; }
    }
}
