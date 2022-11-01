using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace MoviesRepository.Data.Helpers
{
    public static class DbHelper
    {
        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection("Data Source=:memory:");
            connection.Open();
            return connection;
        }

        public static void FillData(SQLiteConnection connection, DataSet dataSet)
        {
            FillTable(connection, dataSet, "category");
            FillTable(connection, dataSet, "actor");
            FillTable(connection, dataSet, "movie");
            FillTable(connection, dataSet, "movie_actor");
        }

        private static void FillTable(SQLiteConnection connection, DataSet dataSet, string tableName)
        {
            using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM " + tableName, connection))
            {
                SQLiteCommandBuilder commandBuilder = new SQLiteCommandBuilder(adapter);
                adapter.Update(dataSet, tableName);
            }
        }
       public static void InitSchema(SQLiteConnection connection)
        {
            string sql = ReadResource("assets.schema.actor.sql")
                         + ReadResource("assets.schema.category.sql")
                         + ReadResource("assets.schema.movie.sql")
                         + ReadResource("assets.schema.movie_actor.sql");

            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public static string ReadResource(string fileName)
        {
            var assembly = typeof(DbHelper).GetTypeInfo().Assembly;
            string[] names = assembly.GetManifestResourceNames();
            using (var stream = assembly.GetManifestResourceStream($"MovieRepository.Data.{fileName}"))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }


    }
}