using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySession.Models;

namespace MySession.Controllers
{
    public class HomeController : Controller
    {
        string SessionName = "_Name";
        string SessionAge = "_Age";
        
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString(SessionName, "addmin");
            HttpContext.Session.SetInt32(SessionAge, 24);

            //HttpContext.Session.SetString(ArrayStr[0], "test");
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            ViewBag.Age = HttpContext.Session.GetInt32(SessionAge);

            ViewData["Message"] = "Get Session";
            return View();
        }
        public IActionResult DeleSession()
        {
            HttpContext.Session.Remove(SessionName);
            HttpContext.Session.Remove(SessionAge);
            //HttpContext.Session.Clear();
            return View();
    
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page";

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
