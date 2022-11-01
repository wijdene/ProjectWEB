using MoviesRepository.Data.Models;

namespace MoviesRepository.Data.Repositories
{
    public interface IMovieReport
    {
        MoviesReportItem[] Get(int? limit, int? fromYear, int? toYear, int[] categoriesIds);
    }
}