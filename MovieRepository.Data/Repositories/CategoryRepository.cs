using System;
using MoviesRepository.Data.Models;
using System.Collections.Generic;
using System.Data.SQLite;
using MoviesRepository.Data.Helpers;
using System.Data;
using System.Linq;

namespace MoviesRepository.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private SQLiteConnection connection;
        //DataSet dataSet = new DataSet();
        public CategoryRepository(SQLiteConnection connection)
        {
            this.connection = connection;
            
        }
        //public CategoryRepository(SQLiteConnection connection, DataSet dataSet)
        //{
        //    this.connection = connection;
        //    this.dataSet = dataSet;
        //}



        public Category FindByName(string name)
        {
            try
            {
                // if (dataSet.Tables[0].Rows.Count > 0)
                //{
                //DataRow row = this.dataSet.Tables[0].Select("name = '" + name+ "'").FirstOrDefault();
                DataRow row = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].Select("name = '" + name + "'").FirstOrDefault();
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
                 
              //  int max = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].Select(K[33])

                //DataRow _ravi = DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].NewRow();
                //_ravi["Name"] = category.Name;
                //_ravi["Id"] =22;
                DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].Rows.Add(22, category.Name);
                DataSetHelper.CreateFlatXMLDataSettDefault().AcceptChanges();
                return true;

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

              return  DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].Rows.Count;
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

                DataRow row= DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].Select("Id =" + id).FirstOrDefault();
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
                return DataSetHelper.CreateFlatXMLDataSettDefault().Tables["category"].AsEnumerable().Select(row => new Category(row["Name"].ToString(), int.Parse(row["Id"].ToString())));

                //}
                // else
            }
            catch (Exception ex) {

                throw;
            }


        }
    }
}