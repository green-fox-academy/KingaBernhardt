using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    public class AssigneController : Controller
    {
        private AssigneRepository assigneRepo;
        public AssigneController(AssigneRepository assigneRepo)
        {
            this.assigneRepo = assigneRepo;
        }

        public IActionResult ListAssigne()
        {
            return View(assigneRepo.GetList());
        }

        public IActionResult GetAssigne(string Name)
        {
            return View("Assigne");
        }




    }
}