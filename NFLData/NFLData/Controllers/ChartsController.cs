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
            
            //code for viewbag

            List<SelectListItem> names = new List<SelectListItem>();

            var namez = dc.GetAllQBNames();

            foreach(var item in namez)
            {
                names.Add(new SelectListItem { Text = item.Name, Value = item.Name});
                ViewBag.AllNames = new SelectList(names, "Value", "Text");
            }

            List<SelectListItem> names2 = new List<SelectListItem>();

            var namez2 = dc.GetAllQBNames();

            foreach (var item in namez2)
            {
                names2.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                ViewBag.AllNames2 = new SelectList(names, "Value", "Text");
            }

            //end of the viewbag code

            return View();
        }

        //if I ever need to revert to the old search just add two params here and pass em too data controller and drop the whole viewbag and then use the commented forms in view
        //takes the form from statchart view and passes it to data controller
        [HttpPost]
        public ActionResult StatChart(FormCollection form)
        {

            ChartsDataController dc = new ChartsDataController("DefaultConnection");

            //start of code for select list

            List<SelectListItem> names = new List<SelectListItem>();

            var namez = dc.GetAllQBNames();

            foreach (var item in namez)
            {
                names.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                ViewBag.AllNames = new SelectList(names, "Value", "Text");
            }

            List<SelectListItem> names2 = new List<SelectListItem>();

            var namez2 = dc.GetAllQBNames();

            foreach (var item in namez2)
            {
                names2.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                ViewBag.AllNames2 = new SelectList(names, "Value", "Text");
            }
            
            //end of code for select list

            StatComparison pm = dc.CompareQuarterbacks(form["AllNames"],form["AllNames2"]);


            return View(pm); 
        }

    }
}