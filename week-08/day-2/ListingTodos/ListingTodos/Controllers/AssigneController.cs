using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repository;
using ListingTodos.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    public class AssigneController : Controller
    {
        private ITodoService todoService;
        public AssigneController(ITodoService todoService)
        {
            this.todoService = todoService;
        }
        [HttpGet("/ListAssigne")]
        public IActionResult ListAssigne()
        {
            return View(todoService.GetAssigneList());
        }

        public IActionResult GetAssigneList(string Name)
        {
            return View("AssigneList");
        }

        [HttpGet("/AddAssigne")]
        public IActionResult AddAssigne()
        {
            return View("Add");
        }

        [HttpPost("/AddAssigne")]
        public IActionResult AddAssigne(Assigne assigne)
        {
            todoService.AddAssigne(assigne);
            return Redirect("ListAssigne");
        }

        [HttpGet("/{id}/deleteAssigne")]
        public IActionResult Delete(int id)
        {
            todoService.RemoveAssigne(id);
            return RedirectToAction("ListAssigne");
        }

        [HttpGet("/{id}/editAssigne")]
        public IActionResult Edit(long id)
        {
            return View("Edit", todoService.GetAssigneId(id));
        }

        [HttpPost("/{id}/editAssigne")]
        public IActionResult Edit(Assigne assigne)
        {
            todoService.EditAssigne(assigne);
            return RedirectToAction("ListAssigne");
        }

        [HttpPost("/GetAssigne")]
        public IActionResult GetAssigne(string Name)
        {
            return View("AssigneList", todoService.GetSearchedAssigne(Name));
        }
    }
}