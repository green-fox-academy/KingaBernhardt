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

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        [HttpGet("/List")]
        public IActionResult List(List<Todo> todos)
        {
            return View(todoRepository.ToDo.ToList());
        }

        [HttpPost]
        public IActionResult AddPokemon(Todo todo)
        {
            todoRepository.ToDos.Add(todo);
            todoRepository.SaveChanges();
            return Redirect("Index");
        }
    }
}