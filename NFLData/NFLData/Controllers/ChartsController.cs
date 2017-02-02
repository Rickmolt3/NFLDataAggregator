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
    public class ChartsController : Controller
    {
        public ActionResult StatChart()
        {
            ChartsDataController dc = new ChartsDataController("DefaultConnection");

            YardageModel pm = dc.GetYards("Matt Ryan");

            return View(pm);
        }
       //charts controller shit goes here.
       //need to decide on what kind of chart i want to display
       //let the user select a certain player and then display there certain stats in a grphics way

    }
}