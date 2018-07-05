using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{

    public class TodoController : Controller
    {
        private TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("/List")]
        public IActionResult List()
        {
            return View(todoRepository.GetList());
        }

        [HttpGet("/AddTodo")]
        public IActionResult AddTodo()
        {
            return View("Add");
        }

        [HttpPost("/AddTodo")]
        public IActionResult AddTodo(Todo todo)
        {
            todoRepository.Add(todo);
            return RedirectToAction("List");
        }

        [HttpGet("/{id}/delete")]
        public IActionResult Delete(int id)
        {
            todoRepository.Remove(id);
            return RedirectToAction("List");
        }

        [HttpGet("/{id}/edit")]
        public IActionResult Edit(long id)
        {
            return View("Edit", todoRepository.GetId(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult Edit(Todo todo)
        {
            todoRepository.Edit(todo);
            return RedirectToAction("List");
        }

        [HttpPost("/GetTodo")]
        public IActionResult GetTodo(string Title)
        {
            return View("List", todoRepository.GetTodo(Title));
        }
    }
}