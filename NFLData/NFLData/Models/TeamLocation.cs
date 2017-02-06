using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLData.Models
{
    public class TeamLocation
    {
        public string TeamName { get; set; }

        public string Location { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}