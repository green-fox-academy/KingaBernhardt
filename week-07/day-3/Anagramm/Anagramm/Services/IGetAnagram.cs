﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagramm.Services
{
    public interface IGetAnagram
    {
        string CheckAnagram(string input, string input2);
    }
}
