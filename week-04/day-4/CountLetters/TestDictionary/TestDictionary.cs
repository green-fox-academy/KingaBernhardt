using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountLetters
{
    [TestFixture]
    public class TestDictionary
    {
        [TestCase]
        public void TestDictionaryKeyValueFunction()
        {
            Program program = new Program();
            string testWord = "thinkable";
            Assert.AreEqual(program.CountLetters(testWord),);
        }
    }
}
