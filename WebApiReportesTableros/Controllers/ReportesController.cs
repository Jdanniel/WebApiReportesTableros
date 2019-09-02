using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using WebApiReportesTableros.Models;

namespace WebApiReportesTableros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportesController : ControllerBase
    {
        private readonly ELAVONContext _context;
        private readonly IConfiguration configuracion;
        private readonly string appname;
        private readonly static Random random = new Random();


        public ReportesController(ELAVONContext context, IConfiguration iConfig)
        {
            configuracion = iConfig;
            _context = context;
            appname = configuracion.GetValue<string>("MySettings:appname");
        }

        [HttpPost("Replicas")]
        public async Task<ActionResult> PostReplicas(ReplicasRequest req)
        {
            if (req == null) return BadRequest();

            try
            {
                string folder = "C:\\inetpub\\wwwroot\\" + appname + "\\REPORTES\\REPLICASAPI\\ARCHIVOS";
                string name = "Replicas_" + RandomString(8) + ".xlsx";
                string downloadUrl = folder + "\\" + name;

                FileInfo file = new FileInfo(Path.Combine(folder,name));

                var columnHeaders = new string[]
                {
                    "ODT",
                    "AFILIACION",
                    "COMERCIO",
                    "POBLACION",
                    "ESTADO",
                    "RAZON_SOCIAL",
                    "RFC",
                    "TECNICO_FINAL",
                    "PROVEEDOR_FINAL",
                    "ZONA",
                    "FECHA_ALTA_PROVEEDOR_ORIGINAL",
                    "FECHA_ALTA_ORIGINAL",
                    "FECHA_CIERRE_FINAL",
                    "DIAS_ATENCION",
                    "ESTATUS_FINAL",
                    "CONCLUSIONES_FINAL",
                    "MOTIVO_CANCELACION_FINAL",
                    "MOTIVO_RECHAZO_FINAL",
                    "TIPO_SERVICIO_FINAL"
                };

                if(file.Exists)
                {
                    file.Delete();
                    file = new FileInfo(Path.Combine(folder,name));
                }

                List<ReplicaResponse> replicas = await _context.Query<ReplicaResponse>().FromSql("EXEC SP_GET_REPORTE_REPLICAS @p0, @p1, @p2",
                    req.idservicio,
                    req.fecini,
                    req.fecfin
                ).ToListAsync();

                using (var package = new ExcelPackage(file))
                {
                    var worksheet = package.Workbook.Worksheets.Add("HOJA");
                    using (var cells = worksheet.Cells[1, 1, 1, 18])
                    {
                        cells.Style.Font.Bold = true;
                        cells.Style.Font.Color.SetColor(Color.White);
                        cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        cells.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(0,128,255));
                    }

                    for(int i = 0; i < columnHeaders.Count(); i++)
                    {
                        worksheet.Cells[1, i + 1].Value = columnHeaders[i];
                    }
                    var j = 2;

                    foreach (var replica in replicas)
                    {
                        worksheet.Cells["A" + j].Value = replica.ODT;
                        worksheet.Cells["B" + j].Style.Numberformat.Format = "0";
                        worksheet.Cells["B" + j].Value = Convert.ToInt64(replica.AFILIACION);
                        worksheet.Cells["C" + j].Value = replica.COMERCIO;
                        worksheet.Cells["D" + j].Value = replica.POBLACION;
                        worksheet.Cells["E" + j].Value = replica.ESTADO;
                        worksheet.Cells["F" + j].Value = replica.RAZON_SOCIAL;
                        worksheet.Cells["G" + j].Value = replica.RFC;
                        worksheet.Cells["H" + j].Value = replica.TECNICO_FINAL;
                        worksheet.Cells["I" + j].Value = replica.PROVEEDOR_FINAL;
                        worksheet.Cells["J" + j].Value = replica.ZONA;
                        worksheet.Cells["K" + j].Style.Numberformat.Format = "@";
                        worksheet.Cells["K" + j].Value = String.Format("{0:dd/MM/yyyy HH:mm:ss}", replica.FECHA_ALTA_PROVEEDOR_ORIGINAL);
                        worksheet.Cells["L" + j].Style.Numberformat.Format = "@";
                        worksheet.Cells["L" + j].Value = String.Format("{0:dd/MM/yyyy HH:mm:ss}", replica.FECHA_ALTA_ORIGINAL);
                        worksheet.Cells["M" + j].Style.Numberformat.Format = "@";
                        worksheet.Cells["M" + j].Value = String.Format("{0:dd/MM/yyyy HH:mm:ss}", replica.FECHA_CIERRE_FINAL);
                        worksheet.Cells["N" + j].Value = replica.DIAS_ATENCION;
                        worksheet.Cells["O" + j].Value = replica.ESTATUS_FINAL;
                        worksheet.Cells["P" + j].Value = replica.CONCLUSIONES_FINAL;
                        worksheet.Cells["Q" + j].Value = replica.MOTIVO_CANCELACION_FINAL;
                        worksheet.Cells["R" + j].Value = replica.MOTIVO_RECHAZO_FINAL;
                        worksheet.Cells["S" + j].Value = replica.TIPO_SERVICIO_FINAL;
                        j++;
                    }
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                    package.Save();
                }

                return Ok(name);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}