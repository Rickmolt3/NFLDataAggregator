using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace NFLData.Models
{
    public class StatComparison
    {
        //part of first qb
        public string QBName { get; set; }

        public int QBYards { get; set; }

        public int QBTouchdown { get; set; }

        public int QBRate { get; set; }

        public int QBTotal { get; set; }

        //end of first qb

        //start of second qb
        public string QB2Name { get; set; }

        public int QB2Yards { get; set; }

        public int QB2Touchdown { get; set; }

        public int QB2Rate { get; set; }

        public int QB2Total { get; set; }

        //end of second qb

    }
}