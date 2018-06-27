using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagramm.Services;
using Microsoft.AspNetCore.Mvc;

namespace Anagramm.Controllers
{
    public class AnagramController : Controller
    {
        private IGetAnagram anagram;
        public AnagramController(IGetAnagram anagram)
        {
            this.anagram = anagram;
        }
        [Route("")]
        public IActionResult Try()
        {
            return Redirect("/macipufi");
        }

        [HttpGet("macipufi")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("macipufi")]
        public IActionResult PostAnagram(string input, string input2)
        {
            anagram.CheckAnagram(input, input2);
            return Redirect("anagram");
        }

        [HttpGet("anagram")]
        public IActionResult GetAnagram()
        {
            return View(anagram);
        }
    }
}