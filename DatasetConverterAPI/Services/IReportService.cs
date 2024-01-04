using DatasetConverterAPI.Models;

namespace DatasetConverterAPI.Services
{
    public interface IReportService
    {
        Task<string> RenderReportAsync(List<Movie> movies, Template template);
    }
}
