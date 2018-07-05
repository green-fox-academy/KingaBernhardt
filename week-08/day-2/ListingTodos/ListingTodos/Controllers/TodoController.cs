using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repository;
using ListingTodos.Services;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{

    public class TodoController : Controller
    {
        private ITodoService todoService;
        public TodoController(TodoService todoService)
        {
            this.todoService = todoService;
        }

        [Route("/List")]
        public IActionResult List()
        {
            return View(todoService.GetTodoList());
        }

        [HttpGet("/AddTodo")]
        public IActionResult AddTodo()
        {
            return View("Add");
        }

        [HttpPost("/AddTodo")]
        public IActionResult AddTodo(Todo todo)
        {
            todoService.AddTodo(todo);
            return RedirectToAction("List");
        }

        [HttpGet("/{id}/delete")]
        public IActionResult Delete(int id)
        {
            todoService.RemoveTodo(id);
            return RedirectToAction("List");
        }

        [HttpGet("/{id}/edit")]
        public IActionResult Edit(long id)
        {
            return View("Edit", todoService.GetTodoId(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult Edit(Todo todo)
        {
            todoService.EditTodo(todo);
            return RedirectToAction("List");
        }

        [HttpPost("/GetTodo")]
        public IActionResult GetTodo(string Title)
        {
            return View("List", todoService.GetSearchedTodo(Title));
        }
    }
}