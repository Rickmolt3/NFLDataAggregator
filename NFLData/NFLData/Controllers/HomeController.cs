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

        //useless
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}