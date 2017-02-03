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

            return View();
        }

        [HttpPost]
        public ActionResult StatChart(string quarterback1,string quarterback2)
        {

            ChartsDataController dc = new ChartsDataController("DefaultConnection");

            StatComparison pm = dc.CompareQuarterbacks(quarterback1,quarterback2);

            return View(pm);
        }

    }
}