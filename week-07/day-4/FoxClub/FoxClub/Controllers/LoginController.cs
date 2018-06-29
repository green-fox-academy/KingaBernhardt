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

        [HttpGet]
        public IActionResult GetLogIn()
        {
            return View("PostResult");
        }

        [HttpPost]
        public IActionResult PostResult(string petName)
        {
            giraffeMaker.SetName(petName);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return View(giraffeMaker);
        }

        [HttpPost]
         public IActionResult Info([FromForm] string inputFood, string inputDrink, string trickName)
        {
            giraffeMaker.SetDrink(inputDrink);
            giraffeMaker.SetFood(inputFood);
            giraffeMaker.SetTrick(trickName);
            return RedirectToAction("Info");
        }

        [HttpGet]
        public IActionResult Info()
        {
            
            return View(giraffeMaker);
        }
    }
}