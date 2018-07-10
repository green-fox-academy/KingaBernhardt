using FrontEndWithTest.Models.LogEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndWithTest.Database
{
    public class LogContext : DbContext
    {
        public DbSet<Log> logs { get; set; }
        public LogContext(DbContextOptions<LogContext> options) : base(options)
        {

        }
    }
}
