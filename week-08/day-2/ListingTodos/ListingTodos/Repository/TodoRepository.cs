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

        public void AddTodo(Todo todo)
        {
            todoContext.ToDos.Add(todo);
            todoContext.SaveChanges();
        }

        public Todo GetId(long id)
        {
            return todoContext.ToDos.ToList().FirstOrDefault(x => x.Id == id);
        }

        public void RemoveTodo(int id)
        {
            var removableTodo = todoContext.ToDos.ToList().FirstOrDefault(x => x.Id == id);
            todoContext.ToDos.Remove(removableTodo);
            todoContext.SaveChanges();
        }

        public void Edit(Todo todo)
        {
            todoContext.Update(todo);
            todoContext.SaveChanges();
        }
    }
}
