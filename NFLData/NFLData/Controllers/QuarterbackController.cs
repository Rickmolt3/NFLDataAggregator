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
    public class QuarterbackController : Controller
    {

        //Contains the quarterback stat lookup
        public ActionResult QuarterbackStats()
        {
            return View();
        }

        //takes the form input and passes it to the data controller
        [HttpPost]
        public ActionResult QuarterbackStats(string Quarterback)
        {
            QuarterbackDataController dc = new QuarterbackDataController("DefaultConnection");

            List<PlayerModel> pm = dc.GetPlayer(Quarterback);

            return View("QuarterbackStats",pm);
        }

        //grabs all quarterbacks and all their stats
        public ActionResult AllQBStats()
        {

            QuarterbackDataController dc = new QuarterbackDataController("DefaultConnection");

            List<PlayerModel> pm = dc.GetAllQbs();

            return View("QuarterbackStats",pm);
        }

        //BEGINNING OF THE NEW PAGE HEADER QUARTERBACK YARDS
        //standard controller for the quarterbackyards view
        public ActionResult QuarterbackYards()
        {
            return View();
        }

        //gets a quarterbacks yards and displays it based on their name
        [HttpPost]
        public ActionResult QuarterbackYards(string Quarterback)
        {
            QuarterbackDataController dc = new QuarterbackDataController("DefaultConnection");

            List<YardageModel> pm = dc.GetYardage(Quarterback);

            return View("QuarterbackYards", pm);
        }

        //gets all qbs and their yardage and returns it to the QuarterbackYards view
        public ActionResult AllQBYards()
        {
            QuarterbackDataController dc = new QuarterbackDataController("DefaultConnection");

            List<YardageModel> pm = dc.GetAllYardage();

            IEnumerable<YardageModel> pma = pm.OrderByDescending(x => x.Yards);//by default the yards are sorted from highest to lowest

            return View("QuarterbackYards", pma);
        }

        //write some more controllers here to help in the sorting of the specific stats, refer to the orderbydescending code line above^^
    }
}