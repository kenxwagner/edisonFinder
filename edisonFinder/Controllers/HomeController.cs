using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace edisonFinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Find the innovative talent or demonstrate your own.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Disclaimer()
        {
            ViewBag.Message = "****** DISCLAIMER ******";

            return View();
        }

        public ActionResult Ideas()
        {
            ViewBag.Message = "Ideas";

            return View();
        }


        public ActionResult Inventors()
        {
            ViewBag.Message = "Invent";

            return View();
        }

        public ActionResult Businesses()
        {
            ViewBag.Message = "Businesses";

            return View();
        }



    }
}