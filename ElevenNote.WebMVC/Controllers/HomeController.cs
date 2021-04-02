using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Eleven Note.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Eleven Note Contact Info.";

            return View();
        }
    }
}