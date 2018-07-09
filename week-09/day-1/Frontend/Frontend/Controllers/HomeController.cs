using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/Doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return new JsonResult(new
                {
                    error = "Please provide an input!"
                });
            }
            else
            {
                return new JsonResult(new
                {
                    received = input,
                    result = input * 2
                });
            }
        }

        [HttpGet("/Greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null && title == null)
            {
                return new JsonResult(
                    new
                    {
                        error = "Please provide a name and a title."
                    });
            }
            else if (name == null)
            {
                return new JsonResult(new
                {
                    error = "Please provide a name."
                });
            }
            else if (title == null)
            {
                return new JsonResult(new
                {
                    error = "Please provide a title."
                });
            }
            else
            {
                return new JsonResult(new
                {
                    welcome_message = "Oh, hi there " + name + ", my dear " + title + "!"
                });
            }
        }
        [HttpGet("/Appenda/{appendable}")]
        public IActionResult Appenda(string appendable)
        {
            return new JsonResult(new
            {
                appended = appendable + "a"
            });
        }

        /*[HttpPost("/dountil/{what}")]
        public IActionResult Dountil()
        {
            return new JsonResult(new
            {
               until: 15
            });
        }*/
    }
}

