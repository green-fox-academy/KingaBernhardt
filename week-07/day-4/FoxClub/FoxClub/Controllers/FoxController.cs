using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    public class FoxController : Controller
    {
        private INutritionStore nutrition;
        public FoxController(INutritionStore nutrition)
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
            return View("Fox");
        }

        [HttpPost]
        public IActionResult AddNutrition()
        {
            return RedirectToAction();
        }
    }
}