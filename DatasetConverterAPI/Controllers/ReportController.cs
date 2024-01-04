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
        public async Task<IActionResult> RenderReport([FromBody] ReportViewModel report)
        {
            if (report == null || report.Movies.Count > 10000000)
            {
                return BadRequest("Check if report format is valid.");
            }

            try
            {
                var formattedReport = await _reportService.RenderReportAsync(report.Movies, report.Template);

                return Ok(formattedReport);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Report render error: {ex.Message}");
            }
        }
    }
}
