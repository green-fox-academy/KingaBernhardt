using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloUserRestApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloUserRestApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        [Route("api")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("greeting")]
        public IActionResult Greet(string name)
        {
            Greeting greeting = new Greeting() { Id = 1, Content = "Hello, " + name };
            return new JsonResult(greeting);
        }
    }
}