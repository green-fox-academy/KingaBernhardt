using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Anagramm.Controllers
{
    public class AnagramController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult PostAnagram(string input)
        {
            return View();
        }

        [HttpGet("/")]
        public IActionResult GetAnagram()
        {
            return View();
        }
    }
}