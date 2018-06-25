using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWordlRestApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWordlRestApp.Controllers
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
        public IActionResult Greet()
        {
            Greeting greeting = new Greeting() { Id = 1, Content = "Hello, Kinga" };
            return new JsonResult(greeting);
        }
    }
}