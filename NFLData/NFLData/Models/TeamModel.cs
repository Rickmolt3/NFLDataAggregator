using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLData.Models
{
    public class TeamModel
    {
        //this model is for the seperate nfl teams to display various information about them
        public string TeamName { get; set; }

        public string TeamLocation { get; set; }

        public string Division { get; set; }

        public string Stadium { get; set; }

        public string StadiumCapacity { get; set; }

        //add more team infomation here


    }
}