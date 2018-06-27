using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeOne.Controllers
{
    public class GreetController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Greeting()
        {
            return View();
        }

        [HttpGet("/")]
        public IActionResult Greet()
        {
            return View();
        }
    }
}