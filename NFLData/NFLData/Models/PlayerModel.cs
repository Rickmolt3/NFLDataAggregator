using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace NFLData.Models
{
    public class PlayerModel
    {
        //its a huge model but holds all the data i need for a player search

        [DefaultValue("Search A Quarterback!")]
        public string Quarterback { get; set; }

        [DefaultValue(0)]
        public int Attempt { get; set; }

        [DefaultValue(0)]
        public int Completion { get; set; }

        [DefaultValue(0)]
        public int Yards { get; set; }

        [DefaultValue(0)]
        public double YardsPerAttempt { get; set; }

        [DefaultValue(0)]
        public int Touchdown { get; set; }

        [DefaultValue(0)]
        public int Interception { get; set; }

        [DefaultValue(0)]
        public int Long { get; set; }

        [DefaultValue(0)]
        public int Sack { get; set; }

        [DefaultValue(0)]
        public int Loss { get; set; }

        [DefaultValue(0)]
        public double Rate { get; set; }

        [DefaultValue(0)]
        public int TotalPoints { get; set; }

        [DefaultValue("Home")]
        public string HomeOrAway { get; set; }

        [DefaultValue("2017")]
        public string Year { get; set; }

        public PlayerModel()
        {
            Quarterback = "Search For a QB!";

            Attempt = 0;

            Completion = 0;

            Yards = 0;

            YardsPerAttempt = 0;

            Touchdown = 0;

            Interception = 0;

            Long = 0;

            Sack = 0;

            Loss = 0;

            Rate = 0;

            TotalPoints = 0;

            HomeOrAway = "Home";

            Year = "2016";
        }

    }
}