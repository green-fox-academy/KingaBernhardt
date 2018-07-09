using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models.ArrayModel;
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

        [HttpPost("/dountil/{what}")]
        public IActionResult Dountil(string what, [FromBody] int body)
        {
            if (what == "sum" )
            {
                int result = 0;
                for (int i = 0; i < body; i++)
                {
                    result += i;
                }
                return new JsonResult(new
                {
                    result
                });
            }
            else if (what =="factor")
            {
                int result = 0;
                for (int i = 1; i <= body; i++)
                {
                    result *= i;
                }
                return new JsonResult(new
                {
                    result
                });
            }
            else
            {
                return new JsonResult(new
                {
                    error = "Please provide a number."
                });
            }
        }

        [HttpPost("/arrays")]
        public IActionResult Arrays([FromBody] Arrays array)
        {
            if (array.What == "sum")
            {
                int result = 0;
                for (int i = 0; i < array.Numbers.Count(); i++)
                {
                    result += array.Numbers[i];
                }
                return Json(new { Result = result });
            }
            else if (array.What == "multiply")
            {
                int result = 1;
                for (int i = 0; i < array.Numbers.Count(); i++)
                {
                    result *= array.Numbers[i];
                }
                return Json(new { Result = result });
            }
            else if (array.What == "double")
            {
                int[] result = new int[array.Numbers.Count()];
                for (int i = 0; i < array.Numbers.Count(); i++)
                {
                    result[i] = array.Numbers[i] * 2;
                }
                return Json(new { Result = result });
            }
            else if (array.What == null)
            {
                return new JsonResult(new
                {
                    error = "Please provide what to do with the numbers."
                });
            }
            else
            {
                return new JsonResult(new
                {
                    error = "Please provide numbers."
                });
            }
        }
    }
}

