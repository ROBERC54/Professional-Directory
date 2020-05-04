using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProfessDirectSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us in a few words";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Let's have a conversation";

            return View();
        }
        public ActionResult Obligations()
        {
            ViewBag.Message = "Our commitment to you";

            return View();
        }
        public ActionResult Contribute()
        {
            ViewBag.Message = "Want to lend a hand?";

            return View();
        }

        public ActionResult ComeVisit()
        {
            ViewBag.Message = "Let's get in touch";

            return View();
        }
        public ActionResult Errata()
        {
            ViewBag.Message = "Here are some Extras!";

            return View();
        }
    }
}