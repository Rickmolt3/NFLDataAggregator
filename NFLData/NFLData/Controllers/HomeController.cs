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
    public class HomeController : Controller
    {
        //This is the entry point for the application Home/Index
        public ActionResult Index()
        {
            return View();
        }

        //Contains the quarterback stat lookup
        public ActionResult Quarterback()
        {
            return View();
        }

        //takes the form input and passes it to the data controller
        [HttpPost]
        public ActionResult Quarterback(string Quarterback)
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

            return View("Quarterback", pm);
        }

        //standard controller for the quarterbackyards view
        public ActionResult QuarterbackYards()
        {
            return View("QuarterbackYards");
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

        //takes the selected team from the teams view and then displays all pertinent information
        public ActionResult TeamChoice(string name, string picture)
        {
            //takes the image from the team selection and passes it through to the display page using viewbag
            ViewBag.Logo = string.Format("/FixedImages/{0}", picture);
   
            DataController dc = new DataController("DefaultConnection");

            TeamModel tm = dc.GetTeam(name);
            
            return View(tm);
        }

        //gets all the superbowls and displays them to the views
        public ActionResult SuperBowl()
        {

            DataController dc = new DataController("DefaultConnection");

            List<SuperBowl> sb = dc.GetSuperBowl();

            return View(sb);
        }

        //gets the rushing yards for all the rushing players for the 2016 season
        public ActionResult Rushing()
        {
            DataController dc = new DataController("DefaultConnection");

            List<Rushing> sb = dc.GetRushing();

            return View(sb);
        }

        //gets the recieving yards for all the recieving players for the 2016 season
        public ActionResult Recieving()
        {
            DataController dc = new DataController("DefaultConnection");

            List<Recieving> sb = dc.GetRecieving();

            return View(sb);
        }

        //Contact page for my information and to take up blank space 
        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Information";
            
            //add api request string here
            //put the retured data into github model
            //send the model to the view
            //add the model to the view in the top
            //add the @model.name etc to display the information

            return View();
        }

    }
}