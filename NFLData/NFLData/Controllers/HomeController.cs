using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NFLData.Controllers.DataControllers;
using NFLData.Models;

namespace NFLData.Controllers
{
    public class HomeController : Controller
    {
        //useless start page left index alone
        public ActionResult Index()
        {
            return View();
        }

        //this about is where I stored the code for the data pull
        public ActionResult About()
        {
            return View();
        }

        //takes the form input and passes it to the data controller
        [HttpPost]
        public ActionResult About(string Quarterback)
        {
            DataController dc = new DataController("DefaultConnection");

            List<PlayerModel> pm = dc.GetPlayer(Quarterback);

            return View(pm);
        }

        //grabs all quarterbacks and all their stats
        public ActionResult AllQBStats()
        {         

            DataController dc = new DataController("DefaultConnection");

            List<PlayerModel> pm = dc.GetAllQbs();

            //IEnumerable<PlayerModel> pma = pm.OrderByDescending(x => x.Yards);//by default the yards are sorted from highest to lowest

            return View("About", pm);
        }

        //standard controller for the quarterbackyards view
        public ActionResult QuarterbackYards()
        {
            return View();
        }      

        //gets a quarterbacks yards and displays it based on their name
        [HttpPost]
        public ActionResult QuarterbackYards(string Quarterback)
        {
            DataController dc = new DataController("DefaultConnection");

            List<YardageModel> pm = dc.GetYardage(Quarterback);

            return View(pm);
        }

        //gets all qbs and their yardage and returns it to the QuarterbackYards view
        public ActionResult AllQBYards()
        {
            DataController dc = new DataController("DefaultConnection");

            List<YardageModel> pm = dc.GetAllYardage();

            IEnumerable<YardageModel> pma = pm.OrderByDescending(x => x.Yards);//by default the yards are sorted from highest to lowest

            return View("QuarterbackYards", pma);
        }

        //shows all the nfl teams in a nice front end ish display
        public ActionResult Teams()
        {
            return View();
        }

        //contact page
        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Information";

            return View();
        }

    }
}