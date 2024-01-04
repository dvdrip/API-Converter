using Microsoft.AspNetCore.Authentication;

namespace DatasetConverterAPI.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string TrailerURL { get; set; }
        public int Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal DomesticGross { get; set; }
        public decimal WorldwideGross { get; set; }
        
    }
}
