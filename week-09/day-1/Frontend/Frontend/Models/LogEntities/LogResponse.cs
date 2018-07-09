using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models.LogEntities
{
    public class LogResponse
    {
        public List<Log> logs { get; set; }
        public int EntryCount { get; set; }
    }
}
