﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NFLData.Controllers.DataControllers;
using NFLData.Models;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

namespace NFLData.Controllers
{
    public class HomeController : Controller
    {
        //This is the entry point for the application displays the homepage and the pertaining information Home/Index
        public ActionResult Index()
        {

            return View();
        }

        //Contact page for my information uses gitubs api to pull back data and display it to the user
        public ActionResult Contact()
        {
            ViewBag.Message = "My Contact Information";

            //https://api.github.com/users/rickmolt3
            //add api request string here
            //put the retured data into github model
            //send the model to the view
            //add the model to the view in the top
            //add the @model.name etc to display the information
            return View();
        }



    }
}