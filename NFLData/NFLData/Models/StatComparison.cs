using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NFLData.Models
{
    public class StatComparison
    {
        //part of first qb
        public string QBName { get; set; }

        public int QBYards { get; set; }

        public int QBTouchdown { get; set; }

        //end of first qb

        //start of second qb
        public string QBName2 { get; set; }

        public int QB2Yards { get; set; }

        public int QB2Touchdown { get; set; }
        
        //end of second qb

    }
}