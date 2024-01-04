using DatasetConverterAPI.Models;
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

        [HttpPost]
        public async Task<IActionResult> RenderReport([FromForm] IFormFile datasetFile, [FromForm] IFormFile templateFile)
        {
            string datasetJson;
            string template;

            using (var datasetReader = new StreamReader(datasetFile.OpenReadStream()))
            {
                datasetJson = await datasetReader.ReadToEndAsync();
            }

            using (var templateReader = new StreamReader(templateFile.OpenReadStream()))
            {
                template = await templateReader.ReadToEndAsync();
            }

            //var datasetResult = await JsonConvert.DeserializeObject<Movie>(datasetJson);

            var dataset = JsonConvert.DeserializeObject<Dataset>(datasetJson);
            var templateModel = JsonConvert.DeserializeObject<Template>(template);

            return Ok();
        }
    }
}
