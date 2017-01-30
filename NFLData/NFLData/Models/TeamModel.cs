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
        [DisplayName("Team:")]
        public string TeamName { get; set; }

        [DefaultValue("Atlanta")]
        [DisplayName("City:")]
        public string TeamCity { get; set; }

        [DefaultValue("Some Division")]
        [DisplayName("Division:")]
        public string TeamDivision { get; set; }

        [DefaultValue("Stadium")]
        [DisplayName("Stadium:")]
        public string TeamStadium { get; set; }

        [DefaultValue(0)]
        [DisplayName("Stadium Capacity:")]
        public int TeamStadiumCapacity { get; set; }

        [DefaultValue("A Guy")]
        [DisplayName("Head Coach:")]
        public string TeamHeadCoach { get; set; }

        [DefaultValue(0)]
        public decimal Latitude { get; set; }

        [DefaultValue(0)]
        public decimal Longitude { get; set; }



    }
}