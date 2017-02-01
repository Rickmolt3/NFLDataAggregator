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
    public class SuperbowlController : Controller
    {
        //gets all the superbowls and displays them to the views
        public ActionResult SuperBowl()
        {

            SuperbowlDataController dc = new SuperbowlDataController("DefaultConnection");

            List<SuperBowl> sb = dc.GetSuperBowl();

            return View(sb);
        }
    }
}