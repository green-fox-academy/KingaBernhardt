using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public interface IGetAnagram
    {
        void CheckAnagram(string input, string input2);
        string GetMessage();
    }
}
