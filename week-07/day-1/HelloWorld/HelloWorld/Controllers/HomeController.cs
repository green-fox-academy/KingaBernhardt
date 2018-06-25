using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello Ocelot! This is the default message.");
        }

        [Route("hello")]
        public IActionResult Hello(string name)
        {
            return Content("Hello World " + name);
        }
    }
}