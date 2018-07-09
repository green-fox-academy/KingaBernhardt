using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models.LogEntities
{
    public class Log
    {
        public DateTime CreatedAt { get; set; }
        public string EndPoint { get; set; }
        public string Data { get; set; }
    }
}
