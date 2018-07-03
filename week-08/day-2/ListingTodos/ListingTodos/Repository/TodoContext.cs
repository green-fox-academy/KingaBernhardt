using ListingTodos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repository
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> ToDos { get; set; }
    }
}
