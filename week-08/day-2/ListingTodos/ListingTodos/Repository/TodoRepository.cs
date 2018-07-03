using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repository
{
    public class TodoRepository
    {
        private TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public List<Todo> GetTodoList()
        {
            return todoContext.ToDos.ToList();
        }
    }
}
