using System;
using MoviesRepository.Data.Models;
using System.Collections.Generic;
using System.Data.SQLite;
using MoviesRepository.Data.Helpers;
using System.Data;
using System.Linq;
using MovieRepository.Data.Helpers;

namespace MoviesRepository.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private SQLiteConnection connection;
        //DataSet dataSet = new DataSet();
        //HelperContext dbcontext ;
        public CategoryRepository(SQLiteConnection connection)
        {
            this.connection = connection;


        }
        //public CategoryRepository(SQLiteConnection connection, HelperContext dbcontext)
        //{
        //    this.connection = connection;
        //    this.dbcontext = dbcontext;
        //}



        public Category FindByName(string name)
        {
            try
            {
                // if (dataSet.Tables[0].Rows.Count > 0)
                //{
                //DataRow row = this.dataSet.Tables[0].Select("name = '" + name+ "'").FirstOrDefault();
                DataRow row = DbHelper.GetDataSetTable(connection, "select * from category  where name = '" + name + "'").Tables[0].Select().FirstOrDefault();
                Category category = ConvertRows(row);


                return category;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Save(Category category)
        {


            try
            {
                //    string variabl = "tets";

                //    string variabl2 = "tets2";
                //    string branch = "branch";

                //  int max = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].Select(K[33])

                //DataRow _ravi = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].NewRow();
                //_ravi["Name"] = category.Name;
                //_ravi["Id"] = 50;
                string comd = "";
                if (category.Id == 0)
                {

                    int maxexistee = FindAll().Max(l => l.Id);
                    maxexistee++;
                     comd = "insert into category (Id,Name) values (" + maxexistee + ",'" + category.Name + "')";
                    //DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].Rows.Add(_ravi);
                    //DataSetHelper.CreateFlatXMLDataSettDefault().AcceptChanges();
                }
                else
                {

                     comd = "update  category set Name ='" + category.Name + "' where Id="+ category.Id +"";


                }
                bool logic= DbHelper.excuteCmd(connection,comd);
                return logic;

            }

            catch (Exception ex)
            {

                return false;

            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Helper method for instantiating object from single database row.
        /// </summary>
        /// <param name="reader">The reader.</param>
        /// <returns>The category</returns>
        private static Category Convert(SQLiteDataReader reader)
        {
            var id = reader.GetInt32(0);
            string name = reader.GetString(1);
            Category category = new Category(name, id);
            return category;
        }
        private static Category ConvertRows(DataRow reader)
        {
            var id =int.Parse(reader[0].ToString());
                
             
            string name = reader[1].ToString();
            Category category = new Category(name, id);
            return category;
        }
        public long Count()
        {
            try
            {
                // if (dataSet.Tables[0].Rows.Count > 0)
                //{

              return DbHelper.GetDataSetTable(connection, "select * from category ").Tables[0].Rows.Count;
               // return this.dataSet.Tables[0].Rows.Count;

                //}
                // else
            }
            catch (Exception ex)
            {

                throw;
            }
        }

            public Category Find(int id)
        {
            try
            {
                // if (dataSet.Tables[0].Rows.Count > 0)
                //{
                //DataRow row = this.dataSet.Tables[0].Select("Id == " + id).FirstOrDefault();

                DataRow row= DbHelper.GetDataSetTable(connection, "select * from category where Id = " +id+"").Tables[0].Select().FirstOrDefault();
                Category category = ConvertRows(row);


                return category;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public IEnumerable<Category> FindAll()
        {
            try
            {
                // if (dataSet.Tables[0].Rows.Count > 0)
                //{

                //this.dataSet.Tables[0].AsEnumerable().Select(row => new Category(row["Name"].ToString(), int.Parse(row["Id"].ToString())));

                //}
               //return dbcontext.Category.AsEnumerable();

                return DbHelper.GetDataSetTable(connection, "select * from category ").Tables[0].AsEnumerable().Select(row => new Category(row["Name"].ToString(), int.Parse(row["Id"].ToString())));

                //}
                // else
            }
            catch (Exception ex) {

                throw;
            }


        }
    }
}