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

        [HttpGet("/login")]
        public IActionResult GetLogIn()
        {
            return View();
            
        }

        [HttpPost("")]
        public IActionResult PostResult(string name)
        {
            return Redirect();
        }
    }
}