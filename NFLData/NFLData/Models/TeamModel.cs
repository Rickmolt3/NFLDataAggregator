using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLData.Models
{
    public class TeamModel
    {
        //this model is for the seperate nfl teams to display various information about them

        //add default values and display names for all the properties
        public string TeamName { get; set; }

        public string TeamLocation { get; set; }

        public string Division { get; set; }

        public string Stadium { get; set; }

        //public double StadiumCoordinates { get; set; } wait until I can properly store coord data and recall it

        public string StadiumCapacity { get; set; }

        public string TeamHeadCoach { get; set; }

        //eventual once i work it out team image

        //add more team infomation here, use the wikipedia page


    }
}