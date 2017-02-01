using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.Common;
using System.Web.Mvc;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using NFLData.Models;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace NFLData.Controllers.DataControllers
{
    public class SuperbowlDataController : Controller
    {
        public static SqlDatabase db;

        //connection string code to make SQL connection through the web config
        public SuperbowlDataController(string connectionstring)
        {
            db = new SqlDatabase(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            if (connectionstring.Length > 0)
            {
                if (db == null)
                {
                    db = new SqlDatabase(connectionstring);
                }
            }
            else
            {
                if (db == null)
                {
                    db = new SqlDatabase(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
                }
            }
        }

        public List<SuperBowl> GetSuperBowl()
        {
            DbCommand getSB = db.GetStoredProcCommand("sp_getSB");//returns the quarterback and total yardage for the season

            // Executes stored proc to return values into a DataSet.
            DataSet ds = db.ExecuteDataSet(getSB);

            var bowls = (from drRow in ds.Tables[0].AsEnumerable()
                         select new SuperBowl()
                         {
                             Date = drRow.Field<string>("Date"),
                             SB = drRow.Field<string>("SB"),
                             winner = drRow.Field<string>("Winner"),
                             winnerpts = drRow.Field<string>("Pts"),
                             loser = drRow.Field<string>("Loser"),
                             loserpoints = drRow.Field<string>("LoserPts"),
                             mvp = drRow.Field<string>("MVP"),
                             stadium = drRow.Field<string>("Stadium"),
                             city = drRow.Field<string>("City"),
                             state = drRow.Field<string>("State")

                         }).ToList();

            return bowls;
        }
    }
}