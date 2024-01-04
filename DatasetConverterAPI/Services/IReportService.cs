using DatasetConverterAPI.Models;

namespace DatasetConverterAPI.Services
{
    public interface IReportService
    {
        Task<ReportViewModel> RenderReportAsync(Dataset dataset, Template template);
    }
}
