using Microsoft.AspNetCore.Mvc;
using MoviesRepository.Data.Helpers;
using System.Data;
using System.Data.SQLite;

namespace MoviesRepository.Controllers
{
    public abstract class BaseController : Controller
    {
        //public DataSet dataSet; //mod
        public BaseController()
        {
            Connection = DbHelper.GetConnection();
            DbHelper.InitSchema(Connection);
            DataSet dataSet = DataSetHelper.CreateFlatXMLDataSettDefault();
            DbHelper.FillData(Connection, dataSet);
        }


        //public DataSet getData ()
        //{

        //    return this.da

        //}
        protected SQLiteConnection Connection { get;  private set;}

        protected override void Dispose(bool disposing)
        {
            if (Connection != null)
            {
                Connection.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}