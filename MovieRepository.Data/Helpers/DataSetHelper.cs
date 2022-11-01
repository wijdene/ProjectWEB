using System.Data;
using System.Data.Common;
using System.IO;

namespace MoviesRepository.Data.Helpers
{
    public static class DataSetHelper
    {
        public static DataSet CreateFlatXMLDataSetAfterInsert()
        {
            return GetDataSet(DbHelper.ReadResource("assets.dataset.dataset-after-insert.xml"));
        }

        public static DataSet CreateFlatXMLDataSetAfterUpdate()
        {
            return GetDataSet(DbHelper.ReadResource("assets.dataset.dataset-after-update.xml"));
        }

        public static DataSet CreateFlatXMLDataSettDefault()
        {
            return GetDataSet(DbHelper.ReadResource("assets.dataset.dataset.xml"));
        }

        private static DataSet GetDataSet(string data)
        {
            DataSet dataSet = new DataSet();
            using (var schemaReader = new StringReader(DbHelper.ReadResource("assets.dataset.schema.xsd")))
            {
                dataSet.ReadXmlSchema(schemaReader);
            }

            using (var dataReader = new StringReader(data))
            {
                dataSet.ReadXml(dataReader);
            }
            
            return dataSet;
        }

        //private static void InsertDataSet(string data)
        //{
        //    DataSet dataSet = new DataSet();
        //    using (var schemaReader = new StringReader(DbHelper.ReadResource("assets.dataset.schema.xsd")))
        //    {
        //        dataSet.ReadXmlSchema(schemaReader);
        //    }

        //    using (var dataReader = new StringReader(data))
        //    {
        //        dataSet.ReadXml(dataReader);
        //    }

            
        //}
    }
}