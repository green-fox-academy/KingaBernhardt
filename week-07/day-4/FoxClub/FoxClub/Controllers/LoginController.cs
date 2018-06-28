using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class LoginController : Controller
    {
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