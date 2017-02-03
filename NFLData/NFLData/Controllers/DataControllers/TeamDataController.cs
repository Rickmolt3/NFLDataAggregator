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
    public class TeamDataController : Controller
    {
        public static SqlDatabase db;

        //connection string code to make SQL connection through the web config
        public TeamDataController(string connectionstring)
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
                recieverName = dr.Field<string>("Player"),
                recieverPosition = dr.Field<string>("recievingPosition"),
                rusherName = dr.Field<string>("Name"),
                rusherPosition = dr.Field<string>("runningPosition"),
                
            };

            return team;
        }

        //gets all the team location data from the db for every team
        public List<TeamLocation> GetTeamLocation()
        {
            DbCommand getSB = db.GetStoredProcCommand("sp_GetTeamLocation");

            // Executes stored proc to return values into a DataSet.
            DataSet ds = db.ExecuteDataSet(getSB);

            var location = (from drRow in ds.Tables[0].AsEnumerable()
                         select new TeamLocation()
                         {

                             Location = drRow.Field<string>("TeamCity"),
                             Latitude = drRow.Field<decimal>("Latitude"),
                             Longitude = drRow.Field<decimal>("Longitude"),
                            
                         }).ToList();

            return location;
        }
    }
}