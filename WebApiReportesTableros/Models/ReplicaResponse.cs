using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiReportesTableros.Models
{
    public class ReplicaResponse
    {
        [JsonProperty("ODT")]
        public string ODT { get; set; }

        [JsonProperty("AFILIACION")]
        public string AFILIACION { get; set; }

        [JsonProperty("COMERCIO")]
        public string COMERCIO { get; set; }

        [JsonProperty("POBLACION")]
        public string POBLACION { get; set; }

        [JsonProperty("ESTADO")]
        public string ESTADO { get; set; }

        [JsonProperty("RAZON_SOCIAL")]
        public string RAZON_SOCIAL { get; set; }

        [JsonProperty("RFC")]
        public string RFC { get; set; }

        [JsonProperty("TECNICO_FINAL")]
        public string TECNICO_FINAL { get; set; }

        [JsonProperty("PROVEEDOR_FINAL")]
        public string PROVEEDOR_FINAL { get; set; }

        [JsonProperty("ZONA")]
        public string ZONA { get; set; }

        [JsonProperty("FECHA_ALTA_PROVEEDOR_ORIGINAL")]
        public DateTime? FECHA_ALTA_PROVEEDOR_ORIGINAL { get; set; }

        [JsonProperty("FECHA_ALTA_ORIGINAL")]
        public DateTime? FECHA_ALTA_ORIGINAL { get; set; }

        [JsonProperty("FECHA_CIERRE_FINAL")]
        public DateTime? FECHA_CIERRE_FINAL { get; set; }

        [JsonProperty("DIAS_ATENCION")]
        public int DIAS_ATENCION { get; set; }

        [JsonProperty("ESTATUS_FINAL")]
        public string ESTATUS_FINAL { get; set; }

        [JsonProperty("CONCLUSIONES_FINAL")]
        public string CONCLUSIONES_FINAL { get; set; }

        [JsonProperty("MOTIVO_CANCELACION_FINAL")]
        public string MOTIVO_CANCELACION_FINAL { get; set; }

        [JsonProperty("MOTIVO_RECHAZO_FINAL")]
        public string MOTIVO_RECHAZO_FINAL { get; set; }

        [JsonProperty("TIPO_SERVICIO_FINAL")]
        public string TIPO_SERVICIO_FINAL { get; set; }

        [JsonProperty("OBSERVACIONES_FINALES")]
        public string OBSERVACIONES_FINAL { get; set; }

        [JsonProperty("ID_SERVICIO")]
        public int ID_SERVICIO { get; set; }
        [JsonProperty("BITACORA")]
        public string BITACORA { get; set; }
    }
}
