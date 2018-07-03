using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListingTodos.Models;
using ListingTodos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ListingTodos.Controllers
{
    [Route("/todo")]
    public class TodoController : Controller
    {
        private TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }
        
        [Route("/list")]
        public IActionResult List()
        {
            return View(todoRepository.GetTodoList());
        }

        [HttpPost("/AddTodo")]
        public IActionResult AddTodo(Todo todo)
        {
            todoRepository.AddTodo(todo);
            return RedirectToAction("List");
        }
    }
}