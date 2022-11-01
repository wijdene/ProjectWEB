using System.Data;
using System.Data.SQLite;
using System.Linq;
using MoviesRepository.Data.Helpers;
using MoviesRepository.Data.Models;
using MoviesRepository.Data.Repositories;
using NUnit.Framework;

namespace MoviesRepository.Tests.Base
{
    [TestFixture]
    public class CategoryRepositoryTests : BaseTest
    {
        protected CategoryRepository repository;

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

        [Test]
        public void ThatCategoryRepositoryCountReturnsSameCountOfCategoriesAsInDatabase()
        {
            // Act
            var count = repository.Count();

            // Assert
            int excpected = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].Rows.Count;
            Assert.AreEqual(excpected, count);
        }

        [Test]
        public void ThatCategoryRepositoryFindReturnsSameCategoryAsInDatabase()
        {
            // Arrange
            var id = 1;

            // Act
            var category = repository.Find(id);

            // Assert
            var dataSetTable = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"];

            for (int i = 0; i < dataSetTable.Rows.Count; i++)
            {
                var datasSetRow = dataSetTable.Rows[i];
                var rowId = int.Parse(datasSetRow["id"].ToString());
                if (rowId == id)
                {
                    Assert.AreEqual(rowId, category.Id);
                    Assert.AreEqual(datasSetRow["name"], category.Name);

                    return;
                }
 
            }

            Assert.Fail("Invalid test parameter or dataset");
        }

        [Test]
        public void ThatCategoryRepositoryFindByNameReturnsSameCategoryAsInDatabase()
        {
            // Arrange
            var name = "Comedy";

            // Act
            var category = repository.FindByName(name);

            // Assert
            var dataSetTable = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"];

            for (int i = 0; i < dataSetTable.Rows.Count; i++)
            {
                var datasSetRow = dataSetTable.Rows[i];
                var rowName = datasSetRow["name"] as string;
                if (rowName == name)
                {
                    Assert.AreEqual(int.Parse(datasSetRow["id"].ToString()), category.Id);
                    Assert.AreEqual(rowName, category.Name);

                    return;
                }

            }

            Assert.Fail("Invalid test parameter or dataset");
        }

        [Test]
        public void ThatCategoryRepositoryGetAllReturnsAllCategoriesFromDatabase()
        {
            // Act
            var categories = repository.FindAll();

            // Assert
            var dataSetTable = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"];
            for (int i = 0; i < categories.Count(); i++)
            {
                var category = categories.ElementAt(i);
                var datasSetRow = dataSetTable.Rows[i];

                Assert.AreEqual(int.Parse(datasSetRow["id"].ToString()), category.Id);
                Assert.AreEqual(datasSetRow["name"], category.Name);
            }

            Assert.AreEqual(dataSetTable.Rows.Count, categories.Count());
        }

        [Test]
        public void ThatCategoryRepositorySaveAddsNewCategoryToDatabase()
        {
            // Arrange
            var category = new Category("Western");

            // Act
            repository.Save(category);

            // Assert
            var dataSetFromDb = GetDataSet();
            var dataSetExpected = DataSetHelper.CreateFlatXMLDataSetAfterInsert();

            Assert.AreEqual(dataSetFromDb.Tables["category"].Rows.Count, dataSetExpected.Tables["category"].Rows.Count);
            for (int i = 0; i < dataSetFromDb.Tables["category"].Rows.Count; i++)
            {
                var dbRow = dataSetFromDb.Tables["category"].Rows[i];
                var expectedRow = dataSetExpected.Tables["category"].Rows[i];
                Assert.AreEqual(dbRow[0].ToString(), expectedRow[0].ToString());
                Assert.AreEqual(dbRow[1].ToString(), expectedRow[1].ToString());
            }
        }

        [Test]
        public void ThatCategoryRepositorySaveUpdatesExistingCategoryInDatabase()
        {
            // Arrange
            var category = new Category("Action CHANGED", 1);

            // Act
            repository.Save(category);

            // Arrange
            var dataSetFromDb = GetDataSet();
            var dataSetExpected = DataSetHelper.CreateFlatXMLDataSetAfterUpdate();

            Assert.AreEqual(dataSetFromDb.Tables["category"].Rows.Count, dataSetExpected.Tables["category"].Rows.Count);
            for (int i = 0; i < dataSetFromDb.Tables["category"].Rows.Count; i++)
            {
                var dbRow = dataSetFromDb.Tables["category"].Rows[i];
                var expectedRow = dataSetExpected.Tables["category"].Rows[i];
                Assert.AreEqual(dbRow[0].ToString(), expectedRow[0].ToString());
                Assert.AreEqual(dbRow[1].ToString(), expectedRow[1].ToString());
            }
        }

        protected DataSet GetDataSet()
        {
            string sql = "SELECT * FROM category; SELECT * FROM actor; SELECT * FROM movie; SELECT * FROM movie_actor;";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataSet.Tables[0].TableName = "category";
            dataSet.Tables[1].TableName = "actor";
            dataSet.Tables[2].TableName = "movie";
            dataSet.Tables[3].TableName = "movie_actor";

            return dataSet;
        }
    }
}