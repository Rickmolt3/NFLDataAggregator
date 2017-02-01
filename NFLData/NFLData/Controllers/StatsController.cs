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
    }
}