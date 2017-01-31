using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace NFLData.Models
{
    public class SuperBowl
    {
        [DisplayName("Date")]
        public string Date { get; set; }

        [DisplayName("Numeral")]
        public string SB { get; set; }

        [DisplayName("Winner")]
        public string winner { get; set; }

        [DisplayName("Points")]
        public string winnerpts { get; set; }

        [DisplayName("Loser")]
        public string loser { get; set; }

        [DisplayName("Points")]
        public string loserpoints { get; set; }

        [DisplayName("MVP")]
        public string mvp { get; set; }

        [DisplayName("Stadium")]
        public string stadium { get; set; }

        [DisplayName("City")]
        public string city { get; set; }

        [DisplayName("State")]
        public string state { get; set; }
    }
}