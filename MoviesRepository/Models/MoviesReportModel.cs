using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesRepository.Data.Models;
using System.Collections.Generic;

namespace MoviesRepository.Models
{
    public class MoviesReportModel
    {
        public IEnumerable<SelectListItem> Categories { get; set; }
        public int? CategoryId { get; set; }
        public int? FromYear { get; set; }
        public int Limit { get; set; }
        public IEnumerable<MoviesReportItem> SearchResults { get; set; }
        public int? ToYear { get; set; }
    }
}