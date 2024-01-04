using DatasetConverterAPI.Models;
using DatasetConverterAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace DatasetConverterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpPost]
        public async Task<IActionResult> RenderReport([FromForm] Dataset datasetFile, [FromForm] Template templateFile)
        {
            try
            {
                var dataset = datasetFile;
                var templateResult = JsonConvert.DeserializeObject<Template>(templateFile.TemplateTitle);

                var report = await _reportService.RenderReportAsync(dataset, templateResult);

                return Ok(report);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Report render error: {ex.Message}");
            }
        }
    }
}
