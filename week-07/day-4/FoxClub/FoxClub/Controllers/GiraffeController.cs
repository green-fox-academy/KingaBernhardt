using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class GiraffeController : Controller
    {
        private INutritionStore nutrition;
        public GiraffeController(INutritionStore nutrition)
        {
            this.nutrition = nutrition; 
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Nutrition()
        {
            return View(nutrition);
        }

        [HttpPost]
        public IActionResult AddNutrition()
        {
            return RedirectToAction("Info");
        }

        [HttpGet]
        public IActionResult Show()
        {
            return View();
        }
    }
}