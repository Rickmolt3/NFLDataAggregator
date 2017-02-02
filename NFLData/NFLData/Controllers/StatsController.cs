using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NFLData.Controllers.DataControllers;
using NFLData.Models;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace NFLData.Controllers
{
    public class StatsController : Controller
    {
        //gets the rushing yards for all the rushing players for the 2016 season
        public ActionResult Rushing()
        {
            return View();
        }

        //gets all of the rushing stats
        public ActionResult AllRushing()
        {
            StatsDataController dc = new StatsDataController("DefaultConnection");

            List<Rushing> sb = dc.GetRushing();

            return View("Rushing",sb);
        }

        //takes the form input and passes it to the data controller
        [HttpPost]
        public ActionResult Rushing(string Rushing)
        {
            StatsDataController dc = new StatsDataController("DefaultConnection");

            List<Rushing> pm = dc.GetRushingStats(Rushing);

            return View("Rushing", pm);
        }


        //gets the recieving yards for all the recieving players for the 2016 season
        public ActionResult Recieving()
        {
            return View();
        }

        //gets all the recieiving 
        public ActionResult AllRecieving()
        {
            StatsDataController dc = new StatsDataController("DefaultConnection");

            List<Recieving> sb = dc.GetRecieving();

            return View("Recieving",sb);
        }

        //takes the form input and passes it to the data controller
        [HttpPost]
        public ActionResult Recieving(string Recieving)
        {
            StatsDataController dc = new StatsDataController("DefaultConnection");

            List<Recieving> pm = dc.GetRecievingStats(Recieving);

            return View("Recieving", pm);
        }

    }
}