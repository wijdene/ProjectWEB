using MoviesRepository.Data.Helpers;
using MoviesRepository.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

            try
            {
                // if (dataSet.Tables[0].Rows.Count > 0)
                //{

                //this.dataSet.Tables[0].AsEnumerable().Select(row => new Category(row["Name"].ToString(), int.Parse(row["Id"].ToString())));

                //}
                //return dbcontext.Category.AsEnumerable();

                string conditions = "";
                if (fromYear != null)
                {
                    conditions += " year_of_production >= " + fromYear + "";

                }
                // " +(limit !=null ? " TOP "+limit+"" :"") + " 
                string query = " select  movie.title,movie.year_of_production  ,category.name  ,  (select count(*) from movie_actor where movie_id=movie.id) ,'' as vide from movie  inner join  category on category.Id=  movie.category_id   where  movie.id is not null " + (fromYear != null ? "  and year_of_production >= " + fromYear + "" : "") +
                    "" + (toYear != null ? "  and year_of_production >= " + toYear + "" : "") +
                "" + (categoriesIds.Length != 0 ? "  and category_id in (" + String.Join(", ", categoriesIds) + ")" : "") + " " + (limit != null ? " LIMIT " + limit + "" : "");





                MoviesReportItem[] movies;

                SQLiteCommand cmd = new SQLiteCommand(query, connection);

                SQLiteDataReader reader = cmd.ExecuteReader();
                int i = 0;


           
                movies = new MoviesReportItem[] { };
                

                while (reader.Read())
                {

                    movies.Append( Convert(reader));

                }
               // movies = new MoviesReportItem[]
               // {
               //};
                    return movies;

                //}
                // else
            }
            catch (Exception ex)
            {

                throw;
            }

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