﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Anagram
{
    [TestFixture]
    class TestAnagram
    {
        [TestCase]
        public void AnagramsOrNot()
        {
            Program output = new Program();
            bool expectedResult = output.GetAnagram("apple", "elppa");
            Assert.True(expectedResult);
        }
    }
}
