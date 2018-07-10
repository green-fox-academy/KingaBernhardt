﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Models
{
    public class Assigne
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Todo> Todos { get; set; }

        public override string ToString()
        {
            return String.Format(Id + " " + Name + " " + Email);
        }
    }
}
