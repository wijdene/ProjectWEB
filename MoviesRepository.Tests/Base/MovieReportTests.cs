using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using MoviesRepository.Data.Helpers;
using MoviesRepository.Data.Models;
using MoviesRepository.Data.Repositories;
using NUnit.Framework;

namespace MoviesRepository.Tests.Base
{
    [TestFixture]
    public class MovieReportTests : BaseTest
    {
        private ICategoryRepository repository;

        [TearDown]
        public override void CleanUp()
        {
            base.CleanUp();
        }

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            DataSet dataSet = DataSetHelper.CreateFlatXMLDataSettDefault();
            DbHelper.FillData(connection, dataSet);
            repository = new CategoryRepository(connection);
        }

        private int[] GetCategoriesIds(string[] categoryNames)
        {
            List<int> categoryIds = new List<int>();
            if (categoryNames != null)
            {
                foreach (var categoryName in categoryNames)
                {
                    categoryIds.Add(repository.FindByName(categoryName).Id);
                }
            }

            return categoryIds.ToArray();
        }

        [Test]
        public void ThatReportQueriedByNoConditionsReturnsAllValidRowsWithinLimit()
        {
            // Arrange
            int? fromYear = null;
            int? toYear = null;
            string[] categoryNames = null;
            int? limit = 1;
            MoviesReportItem[] expectedResults =
                new MoviesReportItem[]
                {
                    new MoviesReportItem()
                    {
                        Title = "Danny Collins",
                        YearOfProduction = 2015,
                        CategoryName = "Comedy",
                        NumberOfActors = 2,
                        ActorNames = "Al Pacino,Annette Bening"
                    },
                };

            int[] categoryIds = GetCategoriesIds(categoryNames);

            // Act
            var results = new MovieReport(connection).Get(limit, fromYear, toYear, categoryIds);

            // Assert
            Assert.AreEqual(expectedResults, results);
        }

        [Test]
        public void ThatReportQueriedByOneCategoryNameAndLimitReturnsAllValidRowsWithinLimit()
        {
            // Arrange
            int? fromYear = null;
            int? toYear = null;
            string[] categoryNames = new string[] { "Thriller" };
            int? limit = 1;
            MoviesReportItem[] expectedResults =
                new MoviesReportItem[]
                {
                    new MoviesReportItem()
                    {
                        Title = "The Departed",
                        YearOfProduction = 2006,
                        CategoryName = "Thriller",
                        NumberOfActors = 3,
                        ActorNames = "Matt Damon,Leonardo DiCaprio,Jack Nicholson"
                    },
                };

            int[] categoryIds = GetCategoriesIds(categoryNames);

            // Act
            var results = new MovieReport(connection).Get(limit, fromYear, toYear, categoryIds);

            // Assert
            Assert.AreEqual(expectedResults, results);
        }

        [Test]
        public void ThatReportQueriedByDateRangeAndLimitReturnsAllValidRowsWithinLimit()
        {
            // Arrange
            int? fromYear = 1990;
            int? toYear = 2013;
            string[] categoryNames = null;
            int? limit = 1;
            MoviesReportItem[] expectedResults =
                new MoviesReportItem[]
                {
                    new MoviesReportItem()
                    {
                        Title = "Last Vegas",
                        YearOfProduction = 2013,
                        CategoryName = "Comedy",
                        NumberOfActors = 2,
                        ActorNames = "Morgan Freeman,Robert De Niro"
                    },
                };

            int[] categoryIds = GetCategoriesIds(categoryNames);

            // Act
            var results = new MovieReport(connection).Get(limit, fromYear, toYear, categoryIds);

            // Assert
            Assert.AreEqual(expectedResults, results);
        }


        [Test]
        public void ThatReportQueriedByNonRichableConditionsReturnsEmptyResult()
        {
            // Arrange
            int? fromYear = 1990;
            int? toYear = 2010;
            string[] categoryNames = new string[] { "Romance" };
            int? limit = 1;
            MoviesReportItem[] expectedResults = new MoviesReportItem[0];

            int[] categoryIds = GetCategoriesIds(categoryNames);

            // Act
            var results = new MovieReport(connection).Get(limit, fromYear, toYear, categoryIds);

            // Assert
            Assert.AreEqual(expectedResults, results);
        }
    }
}