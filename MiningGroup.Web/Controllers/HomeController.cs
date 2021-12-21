using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiningGroup.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MiningGroup.Web.Controllers
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

        public IActionResult WhoWeAre()
        {
            return View();
        }
        public IActionResult Policy()
        {
            return View();
        }

        public IActionResult OurService()
        {
            return View();
        }

        public IActionResult Media()
        {
            return View();
        }
        public IActionResult NewsAgyoxus()
        {
            return View();
        }
        public IActionResult AzerGoldVideo()
        {
            return View();
        }
        public IActionResult ServiceConsulting()
        {
            return View();
        }
        public IActionResult Drilling()
        {
            return View();
        }
        public IActionResult Geological()
        {
            return View();
        }
        public IActionResult Others()
        {
            return View();
        }
        public IActionResult Reculivation()
        {
            return View();
        }
        public IActionResult Transport()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
