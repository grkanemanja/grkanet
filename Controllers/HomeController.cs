using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace grkovicpsa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {   
            ViewBag.Title = "Exciting cities";
            ViewBag.Keywords = "Tokio,London,Berlin,Rio de Jeneiro,Sidney,Las Vegas";
            return View();
        }

        public ActionResult Onama()
        {
            ViewBag.Title = "About";
            ViewBag.Keywords = "Inspirational,intriguing cities,the population,urban status,World Urbanization Prospects";
            ViewBag.Message = "Something about exiting cities.";

            return View();
        }

        public ActionResult Kontakt ()
        {
            ViewBag.Title = "Contant Us";
            ViewBag.Message = "If you have any questions.";

            return View();
        }
    }
}