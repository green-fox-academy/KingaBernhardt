using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Services;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    public class CountController : Controller
    {
        private ICounter counter;

        public CountController(ICounter counter)
        {
            this.counter = counter;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(counter.GetNumber());
        }
        
        
        [HttpPost("/")]
        public IActionResult RaiseCounter()
        {
            counter.Increase();
            return RedirectToAction("Index");
        }
    }
}