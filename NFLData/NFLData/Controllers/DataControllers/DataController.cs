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
    public class DataController : Controller
    {
        public static SqlDatabase db;

        //connection string code to make SQL connection through the web config
        public DataController(string connectionstring)
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
        
        //data controller to pull all player data based on quarterback name
        public List<PlayerModel> GetPlayer(string Quarterback)
        {
            // Readies stored proc from server.
            DbCommand getQB = db.GetStoredProcCommand("sp_getQB");//write the stored proc

            db.AddInParameter(getQB, "@Quarterback", DbType.String, Quarterback);

            // Executes stored proc to return values into a DataSet.
            DataSet ds = db.ExecuteDataSet(getQB);

            var player = (from drRow in ds.Tables[0].AsEnumerable()
                          select new PlayerModel()
                          {

                              Quarterback = drRow.Field<string>("Quarterback"),
                              Attempt = drRow.Field<int>("Attempt"),
                              Completion = drRow.Field<int>("Completion"),
                              Yards = drRow.Field<int>("Yards"),
                              YardsPerAttempt= drRow.Field<decimal>("YardsPerAttempt"),
                              Touchdown = drRow.Field<int>("Touchdown"),
                              Interception = drRow.Field<int>("Interception"),
                              Long = drRow.Field<int>("Long"),
                              Sack = drRow.Field<int>("Sack"),
                              Loss = drRow.Field<int>("Loss"),
                              Rate = drRow.Field<decimal>("Rate"),
                              TotalPoints = drRow.Field<int>("TotalPoints"),
                              HomeOrAway = drRow.Field<string>("HomeOrAway"),
                              Year = drRow.Field<string>("Year")
                          }).ToList();

            return player;
        }

        //takes a inputed qb and returns all his yards for the 2016 season
        public List<YardageModel> GetYardage(string Quarterback)
        {
            // Readies stored proc from server.
            DbCommand getQB = db.GetStoredProcCommand("sp_getYardage");//returns the quarterback and total yardage for the season

            db.AddInParameter(getQB, "@Quarterback", DbType.String, Quarterback);

            // Executes stored proc to return values into a DataSet.
            DataSet ds = db.ExecuteDataSet(getQB);

            var yardage = (from drRow in ds.Tables[0].AsEnumerable()
                          select new YardageModel()
                          {

                              Quarterback = drRow.Field<string>("Quarterback"),
                              Yards = drRow.Field<int>("Yards")
                              
                          }).ToList();

            return yardage;
        }

        //gets all yardage for all the qbs and populates the yardage model 
        public List<YardageModel> GetAllYardage()
        {
            // Readies stored proc from server.
            DbCommand getQB = db.GetStoredProcCommand("sp_getAllYardage");//returns the quarterback and total yardage for the season

            // Executes stored proc to return values into a DataSet.
            DataSet ds = db.ExecuteDataSet(getQB);

            var yardage = (from drRow in ds.Tables[0].AsEnumerable()
                           select new YardageModel()
                           {

                               Quarterback = drRow.Field<string>("Quarterback"),
                               Yards = drRow.Field<int>("Yards")

                           }).ToList();

            return yardage;
        }

        //gets all individual qbs and their max and average stats
        public List<PlayerModel> GetAllQbs()
        {
            // Readies stored proc from server.
            DbCommand getQB = db.GetStoredProcCommand("sp_getAllQbs");//returns the quarterback and total yardage for the season

            // Executes stored proc to return values into a DataSet.
            DataSet ds = db.ExecuteDataSet(getQB);

            var stats = (from drRow in ds.Tables[0].AsEnumerable()
                           select new PlayerModel()
                           {
                               Quarterback = drRow.Field<string>("Quarterback"),
                               Attempt = drRow.Field<int>("Attempts"),
                               Completion = drRow.Field<int>("Completions"),
                               Yards = drRow.Field<int>("Yards"),
                               YardsPerAttempt = drRow.Field<decimal>("YPAttempt"),
                               Touchdown = drRow.Field<int>("Touchdowns"),
                               Interception = drRow.Field<int>("Interceptions"),
                               Long = drRow.Field<int>("Longest"),
                               Sack = drRow.Field<int>("Sacks"),
                               Loss = drRow.Field<int>("Loss"),
                               Rate = drRow.Field<decimal>("Rate"),
                               TotalPoints = drRow.Field<int>("TotalPoints"),
                               //removed the homeoraway and year columns here

                           }).ToList();

            return stats;
        }

        //gets the selected team and then proceeds to display all the info from the database
        public TeamModel GetTeam(string name)
        {
            // Readies stored proc from server.
            DbCommand getTeam = db.GetStoredProcCommand("sp_GetTeam");//returns the quarterback and total yardage for the season

            //adds a parameter
            db.AddInParameter(getTeam, "@TeamName", DbType.String, name);

            // Executes stored proc to return values into a DataSet.
            DataSet ds = db.ExecuteDataSet(getTeam);

            DataRow dr = ds.Tables[0].Rows[0];

            TeamModel team = new TeamModel()
            {
                TeamName = dr.Field<string>("TeamName"),
                TeamCity = dr.Field<string>("TeamCity"),
                TeamDivision = dr.Field<string>("TeamDivision"),
                TeamHeadCoach = dr.Field<string>("TeamHeadCoach"),
                TeamStadium = dr.Field<string>("TeamStadium"),
                TeamStadiumCapacity = dr.Field<int>("TeamStadiumCapacity"),
                Latitude = dr.Field<decimal>("Latitude"),
                Longitude = dr.Field<decimal>("Longitude"),
            };

            return team;
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