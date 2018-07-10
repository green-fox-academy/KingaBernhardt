using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndWithTest.Database;
using FrontEndWithTest.Models.ArrayModel;
using FrontEndWithTest.Models.DoUntil;
using FrontEndWithTest.Models.LogEntities;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndWithTest.Controllers
{
    public class HomeController : Controller
    {
        /*private LogContext logCont;
        public HomeController(LogContext logCont)
        {
            this.logCont = logCont;
        }*/

        [HttpGet]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/Doubling")]
        public IActionResult Doubling(int? input)
        {
            /*var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = "/doubling",
                Data = $"input={input}"
            };
            logCont.logs.Add(log);
            logCont.SaveChanges();*/

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
            /*var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = "/Greeter",
                Data = $"name={name}&title={title}"
            };
            logCont.logs.Add(log);
            logCont.SaveChanges();*/

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
           /* var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = $"/appenda/{appendable}",
                Data = $"appendable={appendable}"
            };
            logCont.logs.Add(log);
            logCont.SaveChanges();*/

            return new JsonResult(new
            {
                appended = appendable + "a"
            });
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult Dountil(string what, [FromBody] Dountil until)
        {
            /*var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = $"/dountil/{what}",
                Data = $"what={what}&until={until.Until}"
            };
            logCont.logs.Add(log);
            logCont.SaveChanges();*/

            if (what == "sum")
            {
                int result = 0;
                for (int i = 0; i < until.Until; i++)
                {
                    result += i;
                }

                return new JsonResult(new
                {
                    result
                });
            }
            else if (what == "factor")
            {
                int result = 1;
                for (int i = 1; i <= until.Until; i++)
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
            /*var log = new Log
            {
                CreatedAt = DateTime.Now,
                EndPoint = "/arrays",
                Data = $"input={array.ToString()}"
            };
            logCont.logs.Add(log);
            logCont.SaveChanges();*/

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

       /* [HttpGet("/log")]
        public IActionResult Log()
        {
            var response = new LogResponse
            {
                logs = logCont.logs.ToList(),
                EntryCount = logCont.logs.ToList().Count()
            };
            return Json(response);
        }*/
    }
}

