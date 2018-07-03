using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [HttpGet("/")]
        [HttpGet("/List")]
        public IActionResult List()
        {
            return Content("This is your first list");
        }
    }
}