using MoviesRepository.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace MoviesRepository.Data.Repositories
{
    public class MovieReport : IMovieReport
    {
        private SQLiteConnection connection;

        public MovieReport(SQLiteConnection connection)
        {
            this.connection = connection;
        }

        /// <summary>
        /// Returns aggregated data about movies
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="fromYear">The from year. Can be null (no lower limit on production year).</param>
        /// <param name="toYear">The to year. Can be null (no upper limit on production year).</param>
        /// <param name="categoriesIds">The categories ids. Can be empty array or null (all categories should be taken then)</param>
        /// <returns>Array of MovieReportItem</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// fromYear
        /// or
        /// toYear
        /// or
        /// categoriesIds
        /// </exception>
        /// <exception cref="System.ArgumentException">fromYear cannot be greater than toYear</exception>
        public MoviesReportItem[] Get(int? limit = 3, int? fromYear = null, int? toYear = null, params int[] categoriesIds)
        {
            // TODO: Implement it
            // If you don't know how to use aggregation function in SQL or SQLite,
            // please take a look here, https://www.sqlite.org/lang_aggfunc.html

            throw new NotImplementedException();
        }

        /// <summary>
        /// Helper method for instantiating object from single database row.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>The movie report item</returns>
        private static MoviesReportItem Convert(SQLiteDataReader reader)
        {
            return new MoviesReportItem()
            {
                Title = reader.GetString(0),
                YearOfProduction = reader.GetInt32(1),
                CategoryName = reader.GetString(2),
                NumberOfActors = reader.GetInt32(3),
                ActorNames = reader.GetString(4)
            };
        }
    }
}