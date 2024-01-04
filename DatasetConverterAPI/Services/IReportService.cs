using DatasetConverterAPI.Models;

namespace DatasetConverterAPI.Services
{
    public interface IReportService
    {
        Task<string> RenderReportAsync(Dataset dataset, Template template);
    }
}
