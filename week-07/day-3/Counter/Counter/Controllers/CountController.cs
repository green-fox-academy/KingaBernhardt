using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    public class CountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("count")]
        public IActionResult GetCount()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RaiseCounter()
        {
            if (true)
            {

            }
            return View();
        }
    }
}