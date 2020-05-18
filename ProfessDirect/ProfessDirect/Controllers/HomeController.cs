using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProfessDirect.Models;

namespace ProfessDirect.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
