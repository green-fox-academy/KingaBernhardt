using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    public class AssigneController : Controller
    {
        public IActionResult ListAssigne()
        {
            return 
        }

        public IActionResult GetAssigne(string Name)
        {
            
            return View("Assigne");
        }




    }
}