using ListingTodos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Services
{
    public interface ITodoService
    {
        List<Todo> GetTodoList();
        void AddTodo(Todo todo);
        Todo GetTodoId(long id);
        void RemoveTodo(int id);
        void EditTodo(Todo todo);
        List<Todo> GetSearchedTodo(string title);

        List<Assigne> GetAssigneList();
        void AddAssigne(Assigne assigne);
        Assigne GetAssigneId(long id);
        void RemoveAssigne(int id);
        void EditAssigne(Assigne assigne);
        List<Assigne> GetSearchedAssigne(string name);
    }
}
