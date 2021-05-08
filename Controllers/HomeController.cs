using bobur.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace bobur.Controllers
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

        public IActionResult Proish()
        {
            return View();
        }
        public IActionResult Mat()
        {
            return View();
        }
        public IActionResult Tradi()
        {
            return View();
        }
        public IActionResult Rodnoy()
        {
            return View();
        }
        public IActionResult Vostok()
        {
            return View();
        }
        public IActionResult Polit()
        {
            return View();
        }
        public IActionResult Babur()
        {
            return View();
        }
        public IActionResult Diplomat()
        {
            return View();
        }
        public IActionResult Tvorch()
        {
            return View();
        }
        public IActionResult Smert()
        {
            return View();
        }
        public IActionResult Nasledie()
        {
            return View();
        }
        public IActionResult Jeni()
        {
            return View();
        }
        public IActionResult Sochin()
        {
            return View();
        }
        public IActionResult Privacy()
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
