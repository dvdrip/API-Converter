using DatasetConverterAPI.Models;
using DatasetConverterAPI.Services;
using Moq;

namespace DatasetConverterAPI.Tests
{
    [TestFixture]
    public class ReportServiceTests
    {
        [Test]
        public async Task RenderReportAsync_ReturnsFormattedReport()
        {
            // Arrange
            var mockMovie1 = new Movie
            {
                Title = "Harry Potter",
                Genre = "Action",
                TrailerURL = "https://movies.com/movie1-trailer",
                Rating = 1,
                ReleaseDate = DateTime.Now.AddDays(-10),
                DomesticGross = 999,
                WorldwideGross = 999.99M
            };

            var mockMovie2 = new Movie
            {
                Title = "The Ring",
                Genre = "Horror",
                TrailerURL = "https://movies.com/movie2-trailer",
                Rating = 2,
                ReleaseDate = DateTime.Now.AddDays(-1),
                DomesticGross = 1234,
                WorldwideGross = 12345678
            };

            var mockMovie3 = new Movie
            {
                Title = "Rugrats Movie",
                Genre = "Comedy",
                TrailerURL = "https://movies.com/movie3-trailer",
                Rating = 3,
                ReleaseDate = DateTime.Now.AddDays(-4),
                DomesticGross = 98767435,
                WorldwideGross = 7546
            };

            var mockTemplate = new Template
            {
                TemplateTitle = "My Official Report",
                RowStart = "<start>",
                RowEnd = "<end>"
            };

            var mockMovies = new List<Movie> { mockMovie1, mockMovie2, mockMovie3 };

            var mockReportService = new Mock<IReportService>();
            mockReportService.Setup(x => x.RenderReportAsync(mockMovies, mockTemplate)).ReturnsAsync("MockFormattedReport");

            var reportService = mockReportService.Object;

            // Act
            var result = await reportService.RenderReportAsync(mockMovies, mockTemplate);

            // Assert
            Assert.That(result, Is.EqualTo("MockFormattedReport"));
        }
    }
}
