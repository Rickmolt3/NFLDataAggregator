using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace NFLData.Models
{
    public class Rushing
    {
        [DisplayName("Rank")]
        public string Rank { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Team")]
        public string Team { get; set; }

        [DisplayName("Age")]
        public string Age { get; set; }

        [DisplayName("Position")]
        public string Position { get; set; }

        [DisplayName("Games")]
        public string Games { get; set; }

        [DisplayName("Games Started")]
        public string GamesStarted { get; set; }

        [DisplayName("RushAttempts")]
        public string RushAttempts { get; set; }

        [DisplayName("RushYds")]
        public string RushYds { get; set; }

        [DisplayName("RushTD")]
        public string RushTD { get; set; }

        [DisplayName("RushLng")]
        public string RushLng { get; set; }

        [DisplayName("RushYardsAttempt")]
        public string RushYA { get; set; }

        [DisplayName("RushYG")]
        public string RushYG { get; set; }

        [DisplayName("RushAG")]
        public string RushAG { get; set; }

        [DisplayName("RecTargets")]
        public string RecTargets { get; set; }

        [DisplayName("Rec")]
        public string Rec { get; set; }

        [DisplayName("RecYds")]
        public string RecYds { get; set; }

        [DisplayName("RedYR")]
        public string RecYR { get; set; }

        [DisplayName("RedTD")]
        public string RecTD { get; set; }

        [DisplayName("RecLng")]
        public string RecLng { get; set; }

        [DisplayName("RecRG")]
        public string RecRG { get; set; }

        [DisplayName("RecYG")]
        public string RecYG { get; set; }

        [DisplayName("Catch%")]
        public string CatchPercentage { get; set; }

        [DisplayName("ScrimageYds")]
        public string ScrimageYds { get; set; }

        [DisplayName("TotalTds")]
        public string TotalTds { get; set; }

        [DisplayName("Fumble")]
        public string Fumble { get; set; }
    }
}