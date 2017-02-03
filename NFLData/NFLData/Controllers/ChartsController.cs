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

            StatComparison pm = dc.CompareQuarterbacks("Matt Ryan", "Carson Palmer");

            return View(pm);
        }

        [HttpPost]
        public ActionResult StatChart(string quarterback1,string quarterback2)
        {

            ChartsDataController dc = new ChartsDataController("DefaultConnection");

            StatComparison pm = dc.CompareQuarterbacks("matt ryan","aaron rodgers");

            return View("StatChart",pm);
        }

    }
}