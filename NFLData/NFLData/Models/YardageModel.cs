using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace NFLData.Models
{
    public class YardageModel
    {
        //model for the yardage for a season by a certain quarterback

        [DefaultValue("Search A Quarterback!")]
        [DisplayName("Quarterback")]
        public string Quarterback { get; set; }

        [DefaultValue(0)]
        [DisplayName("Yards")]
        public int Yards { get; set; }
    }
}