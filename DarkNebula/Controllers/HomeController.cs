using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Linq;
using DarkNebula.Models;
using System.Xml.Serialization;
using System.IO;

namespace DarkNebula.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var weather = new Weather();

            using(var client = new WebClient())
            {
                var ser = new XmlSerializer(typeof(Weather));

                var x = XDocument.Load("http://www.google.com/ig/api?weather=72712");

                var q = from c in x.Elements()
                        select c.Descendants("forecast_conditions");
            }

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View(weather);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
