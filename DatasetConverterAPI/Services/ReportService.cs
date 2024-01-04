using DatasetConverterAPI.Models;
using System.Text;

namespace DatasetConverterAPI.Services
{
    public class ReportService : IReportService
    {
        public async Task<string> RenderReportAsync(List<Movie> rows, Template template)
        {
            var result = new StringBuilder();

            foreach (var movie in rows)
            {
                result.AppendLine(template.RowStart);
                result.AppendLine($"<field-Title>{movie.Title}</field-Title>");
                result.AppendLine($"<field-Genre>{movie.Genre}</field-Genre>");
                result.AppendLine($"<field-TrailerURL>{movie.TrailerURL}</field-TrailerURL>");
                result.AppendLine($"<field-Rating>{movie.Rating}</field-Rating>");
                result.AppendLine($"<field-ReleaseDate>{movie.ReleaseDate}</field-ReleaseDate>");
                result.AppendLine($"<field-DomesticGross>{movie.DomesticGross}</field-DomesticGross>");
                result.AppendLine($"<field-WorldwideGross>{movie.WorldwideGross}</field-WorldwideGross>");
                result.AppendLine(template.TemplateTitle);
                result.AppendLine(template.RowEnd);
            }

            return await Task.FromResult(result.ToString());
        }
    }
}
