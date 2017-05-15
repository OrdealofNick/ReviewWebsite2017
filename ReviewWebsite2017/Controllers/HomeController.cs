using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ReviewWebsite2017.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Review() {
            return View();
        }

        public IActionResult Single() {
            return View();
        }

        public IActionResult ReviewTwo() {
            return View();
        }

        public IActionResult ReviewThree() {
            return View();
        }

        public IActionResult SignIn() {
            return View();
        }

        public IActionResult SignUp() {
            return View();
        }
    }
}
