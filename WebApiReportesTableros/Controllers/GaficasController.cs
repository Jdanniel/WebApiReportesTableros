using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiReportesTableros.Models;

namespace WebApiReportesTableros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaficasController : ControllerBase
    {
        private readonly ELAVONContext _context;
        private readonly IConfiguration configuracion;
        private readonly string appname;


        public GaficasController(ELAVONContext context, IConfiguration iConfig)
        {
            configuracion = iConfig;
            _context = context;
            appname = configuracion.GetValue<string>("MySettings:appname");
        }

        [HttpPost("TPVSINSTALADAS")]
        public async Task<IEnumerable<TpvsInstaladasGraficaResponse>> getTpvsInstaladas(TpvInstaladaRequest req)
        {
            try
            {
                List<TpvsInstaladasGraficaResponse> tpvs = await _context.Query<TpvsInstaladasGraficaResponse>().FromSql("EXEC SP_GET_REPORTE_MODELOS_PROVEEDOR @p0, @p1",
                    req.fecini,
                    req.fecfin
                ).ToListAsync();
                return tpvs;
            }
            catch (Exception ex)
            {
                List<TpvsInstaladasGraficaResponse> tpvs = new List<TpvsInstaladasGraficaResponse>();
                return tpvs;
            } 
        }
    }
}