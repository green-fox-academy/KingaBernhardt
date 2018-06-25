using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloUserRestApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloUserRestApp.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greet()
        {
            var greeting = new Greeting()
            {
                Id = 1,
                Content = "World"
            };
            return View(greeting);
        }

    }
}