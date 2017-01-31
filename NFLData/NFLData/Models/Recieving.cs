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
        public decimal Rank { get; set; }

        [DisplayName("Name")]
        public string Player { get; set; }

        [DisplayName("Position")]
        public string Position { get; set; }

        [DisplayName("Team")]
        public string Team { get; set; }

        [DisplayName("Receptions")]
        public decimal Receptions { get; set; }

        [DisplayName("Targets")]
        public decimal Targets { get; set; }

        [DisplayName("Yards")]
        public decimal Yards { get; set; }

        [DisplayName("Average")]
        public decimal Average { get; set; }

        [DisplayName("TD's")]
        public decimal TD { get; set; }

        [DisplayName("Long")]
        public decimal LONG { get; set; }

        [DisplayName("20+")]
        public decimal TwentyPlus {get;set;}

        [DisplayName("YA/G")]
        public decimal YardsAGame { get; set; }

        [DisplayName("Fumble")]
        public decimal Fumble { get; set; }

        [DisplayName("YA/C")]
        public decimal YardsAfterCatch { get; set; }

        [DisplayName("FirstDowns")]
        public decimal FirstDowns { get; set; }
    }
}