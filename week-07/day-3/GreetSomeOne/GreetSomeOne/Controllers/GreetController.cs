using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreetSomeOne.Services;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeOne.Controllers
{
    public class GreetController : Controller
    {
        private IGreeter greet;
        public GreetController(IGreeter greet)
        {
            this.greet = greet;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Greeting(string name)
        {
            greet.SetName(name);
            return RedirectToAction("Greet");
        }

        [HttpGet("Greet")]
        public IActionResult Greet()
        {
            return View(greet);
        }
    }
}