using System.Linq;
using MoviesRepository.Data.Repositories;
using NUnit.Framework;

namespace MoviesRepository.Tests.Base
{
    [TestFixture]
    public class CategoryRepositoryEmptyTests : BaseTest
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
            repository = new CategoryRepository(connection);
        }

        [Test]
        public void ThatCategoryRepositoryReturnCountOfZeroWhenDbIsEmpty()
        {
            // Act
            var count = repository.Count();

            // Assert
            Assert.AreEqual(0, count);
        }

        [Test]
        public void ThatCategoryGetAllMethodReturnsNoElementsWhenDbIsEmpty()
        {
            // Act
            var result = repository.FindAll();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result.Any());
        }

        [Test]
        public void ThatCategoryRepositoryReturnsNullWhenQueriedForNonExistingCategoryId()
        {
            // Arrange
            var nonExistingId = -1;

            // Act
            var category = repository.Find(nonExistingId);

            // Assert
            Assert.IsNull(category);
        }
    }
}