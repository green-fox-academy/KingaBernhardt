using System;
using System.Collections.Generic;
using System.Text;

namespace IPrintable
{
    class Todo : IPrintable
    {
        public List<string> AddToList(List<string> todos)
        {
            todos.Add("Buy Fruits");
            todos.Add("Go to the Gym");
            todos.Add("Practice more");
            return todos;
        }

        public string PrintAllFields(List<string> todos)
        {
            return todos.ConvertAll<string>(Converter<<List<string>, string>);
        }
    }
}
