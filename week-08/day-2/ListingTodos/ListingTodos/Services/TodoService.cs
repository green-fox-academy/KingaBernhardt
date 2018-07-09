using ListingTodos.Models;
using ListingTodos.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public class TodoService : ITodoService
    {
        private TodoRepository todoRepository;
        private AssigneRepository assigneRepository;
        public TodoService(TodoRepository todoRepository,AssigneRepository assigneRepository)
        {
            this.todoRepository = todoRepository;
            this.assigneRepository = assigneRepository;
        }

        public void AddAssigne(Assigne assigne)
        {
            Debug.Print("Kinga" + assigne.ToString());
            assigneRepository.Add(assigne);
        }

        public void AddTodo(Todo todo)
        {
            todoRepository.Add(todo);
        }

        public void EditAssigne(Assigne assigne)
        {
            assigneRepository.Edit(assigne);
        }

        public void EditTodo(Todo todo)
        {
            todoRepository.Edit(todo);
        }

        public Assigne GetAssigneId(long id)
        {
            return assigneRepository.GetId(id);
        }

        public List<Assigne> GetAssigneList()
        {
            return assigneRepository.GetList();
        }

        public List<Assigne> GetSearchedAssigne(string name)
        {
            return assigneRepository.GetSearched(name);
        }

        public List<Todo> GetSearchedTodo(string title)
        {
            return todoRepository.GetSearched(title);
        }

        public Todo GetTodoId(long id)
        {
            return todoRepository.GetId(id);
        }

        public List<Todo> GetTodoList()
        {
            return todoRepository.GetList();
        }

        public void RemoveAssigne(int id)
        {
            assigneRepository.Remove(id);
        }

        public void RemoveTodo(int id)
        {
            todoRepository.Remove(id);
        }
    }
}
