using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class LoginController : Controller
    {
        private IGiraffeMaker giraffeMaker;
        public LoginController(IGiraffeMaker giraffeMaker)
        {
            this.giraffeMaker = giraffeMaker;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(" ")]
        public IActionResult GetLogIn()
        {
            return View("info");
            
        }

        [HttpPost]
        public IActionResult PostResult(string name)
        {
            giraffeMaker.SetName(name);
            return Redirect("index");
        }

        [HttpGet("index")]
        public IActionResult Info()
        {
            return View(giraffeMaker.GetName());
        }
    }
}