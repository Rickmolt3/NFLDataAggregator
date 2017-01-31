using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace NFLData.Models
{
    public class Recieving
    {
        [DisplayName("Rank")]
        public int Rank { get; set; }

        [DisplayName("Name")]
        public string Player { get; set; }

        [DisplayName("Position")]
        public string Position { get; set; }

        [DisplayName("Team")]
        public string Team { get; set; }

        [DisplayName("Receptions")]
        public int Receptions { get; set; }

        [DisplayName("Targets")]
        public int Targets { get; set; }

        [DisplayName("Yards")]
        public int Yards { get; set; }

        [DisplayName("Average")]
        public int Average { get; set; }

        [DisplayName("TD's")]
        public int TD { get; set; }

        [DisplayName("Long")]
        public int LONG { get; set; }

        [DisplayName("20+")]
        public int TwentyPlus {get;set;}

        [DisplayName("YA/G")]
        public int YardsAGame { get; set; }

        [DisplayName("Fumble")]
        public int Fumble { get; set; }

        [DisplayName("YA/C")]
        public int YardsAfterCatch { get; set; }

        [DisplayName("FirstDowns")]
        public int FirstDowns { get; set; }
    }
}