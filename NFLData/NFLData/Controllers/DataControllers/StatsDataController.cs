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
    public class StatsDataController : Controller
    {
        public static SqlDatabase db;

        //connection string code to make SQL connection through the web config
        public StatsDataController(string connectionstring)
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

        //gets all the rushing rows from the database
        public List<Rushing> GetRushing()
        {
            DbCommand getRush = db.GetStoredProcCommand("sp_getRushing");

            DataSet ds = db.ExecuteDataSet(getRush);

            var recieve = (from drRow in ds.Tables[0].AsEnumerable()
                           select new Rushing()
                           {
                               Rank = drRow.Field<string>("Rank"),
                               Name = drRow.Field<string>("Name"),
                               Team = drRow.Field<string>("Team"),
                               Age = drRow.Field<string>("Age"),
                               Position = drRow.Field<string>("Position"),
                               Games = drRow.Field<string>("Games"),
                               GamesStarted = drRow.Field<string>("GamesStarted"),
                               RushAttempts = drRow.Field<string>("RushAttempts"),
                               RushYds = drRow.Field<string>("RushYds"),
                               RushTD = drRow.Field<string>("RushTD"),
                               RushLng = drRow.Field<string>("RushLng"),
                               RushYA = drRow.Field<string>("RushYA"),
                               RushYG = drRow.Field<string>("RushYG"),
                               RushAG = drRow.Field<string>("RushAG"),
                               ScrimageYds = drRow.Field<string>("ScrimageYds"),
                               TotalTds = drRow.Field<string>("TotalTds"),
                               Fumble = drRow.Field<string>("Fumble"),

                           }).ToList();

            return recieve;
        }

        //gets all of the recieving rows from the database
        public List<Recieving> GetRecieving()
        {
            DbCommand getRec = db.GetStoredProcCommand("sp_getRecieving");

            DataSet ds = db.ExecuteDataSet(getRec);

            var recieve = (from drRow in ds.Tables[0].AsEnumerable()
                           select new Recieving()
                           {
                               Rank = drRow.Field<int>("Rank"),
                               Player = drRow.Field<string>("Player"),
                               Position = drRow.Field<string>("Position"),
                               Team = drRow.Field<string>("Team"),
                               Receptions = drRow.Field<int>("Receptions"),
                               Targets = drRow.Field<int>("Targets"),
                               Yards = drRow.Field<int>("Yards"),
                               Average = drRow.Field<int>("Average"),
                               TD = drRow.Field<int>("TD"),
                               LONG = drRow.Field<int>("LONG"),
                               TwentyPlus = drRow.Field<int>("20+"),
                               YardsAGame = drRow.Field<int>("YardsAGame"),
                               Fumble = drRow.Field<int>("Fumble"),
                               YardsAfterCatch = drRow.Field<int>("YardsAfterCatch"),
                               FirstDowns = drRow.Field<int>("FirstDowns"),

                           }).ToList();

            return recieve;
        }

        //gets the recieving stats for a specific player
        public List<Recieving> GetRecievingStats(string Reciever)
        {
            DbCommand getRec = db.GetStoredProcCommand("sp_GetRecievingStats");

            db.AddInParameter(getRec, "@Player", DbType.String, Reciever);

            DataSet ds = db.ExecuteDataSet(getRec);

            var recieve = (from drRow in ds.Tables[0].AsEnumerable()
                           select new Recieving()
                           {
                               Rank = drRow.Field<int>("Rank"),
                               Player = drRow.Field<string>("Player"),
                               Position = drRow.Field<string>("Position"),
                               Team = drRow.Field<string>("Team"),
                               Receptions = drRow.Field<int>("Receptions"),
                               Targets = drRow.Field<int>("Targets"),
                               Yards = drRow.Field<int>("Yards"),
                               Average = drRow.Field<int>("Average"),
                               TD = drRow.Field<int>("TD"),
                               LONG = drRow.Field<int>("LONG"),
                               TwentyPlus = drRow.Field<int>("20+"),
                               YardsAGame = drRow.Field<int>("YardsAGame"),
                               Fumble = drRow.Field<int>("Fumble"),
                               YardsAfterCatch = drRow.Field<int>("YardsAfterCatch"),
                               FirstDowns = drRow.Field<int>("FirstDowns"),

                           }).ToList();

            return recieve;
        }

        //gets the rusher by name
        public List<Rushing> GetRushingStats(string Rusher)
        {
            DbCommand getRush = db.GetStoredProcCommand("sp_GetRushingStats");

            db.AddInParameter(getRush, "@Name", DbType.String, Rusher);

            DataSet ds = db.ExecuteDataSet(getRush);

            var rush = (from drRow in ds.Tables[0].AsEnumerable()
                           select new Rushing()
                           {
                               Rank = drRow.Field<string>("Rank"),
                               Name = drRow.Field<string>("Name"),
                               Team = drRow.Field<string>("Team"),
                               Age = drRow.Field<string>("Age"),
                               Position = drRow.Field<string>("Position"),
                               Games = drRow.Field<string>("Games"),
                               GamesStarted = drRow.Field<string>("GamesStarted"),
                               RushAttempts = drRow.Field<string>("RushAttempts"),
                               RushYds = drRow.Field<string>("RushYds"),
                               RushTD = drRow.Field<string>("RushTD"),
                               RushLng = drRow.Field<string>("RushLng"),
                               RushYA = drRow.Field<string>("RushYA"),
                               RushYG = drRow.Field<string>("RushYG"),
                               RushAG = drRow.Field<string>("RushAG"),
                               ScrimageYds = drRow.Field<string>("ScrimageYds"),
                               TotalTds = drRow.Field<string>("TotalTds"),
                               Fumble = drRow.Field<string>("Fumble"),

                           }).ToList();

            return rush;
        }
    }
}