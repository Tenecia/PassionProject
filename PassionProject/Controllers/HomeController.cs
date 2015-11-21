using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassionProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "Post your Questions and Answers Here";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Tiny B&B Cleveland";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About TinyB&B";

            return View();
        }

        public ActionResult BrowseGallery()
        {
            ViewBag.Message = "Photos Here!!!!";

            return View();
        }

        public ActionResult BecomeAHost()
        {
            ViewBag.Message = "Hosting Info Here";

            return View();
        }

        public ActionResult TinyPerks()
        {
            ViewBag.Message = "Perks and Benefits Page!!!!";

            return View();
        }

        public ActionResult Explore()
        {
            ViewBag.Message = "List whats in Cleveland ";

            return View();
        }
    }
}