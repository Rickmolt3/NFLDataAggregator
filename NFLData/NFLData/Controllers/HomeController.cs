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
using System.IO;
using Octokit;
using System.Runtime.Serialization;
using Newtonsoft;
using Newtonsoft.Json.Linq;

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

            //string for my github api request replace rickmolt3 with other github user name for someone elses information
            //https://api.github.com/users/rickmolt3

            //string for getting all of a users github repos
            //https://api.github.com/users/rickmolt3/repos

            //code for my github api request for my github name,bio, and email
            HttpWebRequest request = WebRequest.Create("https://api.github.com/users/rickmolt3") as HttpWebRequest;
            request.Method = "GET";
            request.Proxy = null;
            request.ContentType = "application/json";
            request.UserAgent = "NFLData";

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());

                var content1 = reader.ReadToEnd();

                JObject o = JObject.Parse(content1);

                //paste the json objects into the viewbag and allow them to be used in my view
                ViewBag.bio = o["bio"];
                ViewBag.name = o["name"];
                ViewBag.email = o["email"];
                ViewBag.location = o["location"];
            }


            return View();
        }



    }
}