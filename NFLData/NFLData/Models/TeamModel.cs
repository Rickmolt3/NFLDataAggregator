using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace NFLData.Models
{
    public class TeamModel
    {
        //this model is for the seperate nfl teams to display various information about them

        [DefaultValue("Team")]
        public string TeamName { get; set; }

        [DefaultValue("Atlanta")]
        public string TeamCity { get; set; }

        [DefaultValue("Some Division")]
        public string TeamDivision { get; set; }

        [DefaultValue("Stadium")]
        public string TeamStadium { get; set; }

        //add picture for teams here eventually

        [DefaultValue(0)]
        public int TeamStadiumCapacity { get; set; }

        [DefaultValue("A Guy")]
        public string TeamHeadCoach { get; set; }

        [DefaultValue(0)]
        public decimal Latitude { get; set; }

        [DefaultValue(0)]
        public decimal Longitude { get; set; }



    }
}