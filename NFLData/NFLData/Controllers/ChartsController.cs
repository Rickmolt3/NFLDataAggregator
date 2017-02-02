using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFLData.Controllers
{
    public class ChartsController : Controller
    {
        public ActionResult StatChart()
        {
            return View();
        }
       //charts controller shit goes here.
       //need to decide on what kind of chart i want to display
       //let the user select a certain player and then display there certain stats in a grphics way

    }
}