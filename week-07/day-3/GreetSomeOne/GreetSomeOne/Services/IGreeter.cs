using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOne.Services
{
    public interface IGreeter
    {
        string GetName();
        string SetName(string name);
    }
}
