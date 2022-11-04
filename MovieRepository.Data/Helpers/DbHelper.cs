using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
        public static bool excuteCmd(SQLiteConnection connection, string sql)
        {
            //using (SQLiteConnection conn = new SQLiteConnection(cs))
            {
                try
                {
                    //connection = DbHelper.GetConnection();
                    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                   

                    cmd.ExecuteNonQuery();
                    //connection.Close();
                    return true;
                   // testOutput.WriteLine("Insert Successful");
                }
                catch (Exception ex)
                {


                    //connection.Close();
                    return false;
                    throw ;

                    //  this.testOutput.WriteLine("Failed to open connection: {0}", ex.Message);
                }
            }

        }

        public static DataSet GetDataSetTable(SQLiteConnection connection, string sql)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            //dataSet.Tables[0].TableName = "category";
            //dataSet.Tables[1].TableName = "actor";
            //dataSet.Tables[2].TableName = "movie";
            //dataSet.Tables[3].TableName = "movie_actor";

            return dataSet;
        }
        //protected DataSet AddItemDataSet(SQLiteConnection connection,)
        //{
        //    string sql = "inert into category(Id,Name) values ";

        //    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
        //    {
        //        command.ExecuteNonQuery();
        //    }
        //}
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