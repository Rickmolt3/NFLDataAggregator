using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace NFLData.Models
{
    public class PlayerModel
    {
        //Model for the qb search based on user input

        [DefaultValue("Search A Quarterback!")]
        [DisplayName("Quarterback")]
        public string Quarterback { get; set; }

        [DefaultValue(0)]
        [DisplayName("Pass Attempts")]
        public int Attempt { get; set; }

        [DefaultValue(0)]
        [DisplayName("Pass Completions")]
        public int Completion { get; set; }

        [DefaultValue(0)]
        [DisplayName("Yards")]
        public int Yards { get; set; }

        [DefaultValue(0)]
        [DisplayName("Yards Per Attempt")]
        public double YardsPerAttempt { get; set; }

        [DefaultValue(0)]
        [DisplayName("Touchdown")]
        public int Touchdown { get; set; }

        [DefaultValue(0)]
        [DisplayName("Interceptions")]
        public int Interception { get; set; }

        [DefaultValue(0)]
        [DisplayName("Longest Pass")]
        public int Long { get; set; }

        [DefaultValue(0)]
        [DisplayName("Sacks")]
        public int Sack { get; set; }

        [DefaultValue(0)]
        [DisplayName("Loss")]
        public int Loss { get; set; }

        [DefaultValue(0)]
        [DisplayName("QB Rate")]
        public double Rate { get; set; }

        [DefaultValue(0)]
        [DisplayName("Total Points")]
        public int TotalPoints { get; set; }

        [DefaultValue("Home")]
        [DisplayName("Home Or Away")]
        public string HomeOrAway { get; set; }

        [DefaultValue("2017")]
        [DisplayName("Year")]
        public string Year { get; set; }

        //constructor for the playermodel class in case it is ever needed 
        //public PlayerModel()
        //{
        //    Quarterback = "Search For a QB!";

        //    Attempt = 0;

        //    Completion = 0;

        //    Yards = 0;

        //    YardsPerAttempt = 0;

        //    Touchdown = 0;

        //    Interception = 0;

        //    Long = 0;

        //    Sack = 0;

        //    Loss = 0;

        //    Rate = 0;

        //    TotalPoints = 0;

        //    HomeOrAway = "Home";

        //    Year = "2016";
        //}

    }
}