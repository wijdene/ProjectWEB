using System;
using System.Data.SQLite;
using MoviesRepository.Data.Helpers;
using NUnit.Framework;

namespace MoviesRepository.Tests.Base
{
    [TestFixture]
    public class BaseTest : IDisposable
    {
        protected SQLiteConnection connection;

        [TearDown]
        public virtual void CleanUp()
        {
            if (connection != null)
            {
                connection.Dispose();
            }
        }

        public void Dispose()
        {
            CleanUp();
        }

        [SetUp]
        public virtual void SetUp()
        {
            connection = DbHelper.GetConnection();
            DbHelper.InitSchema(connection);
        }
    }
}