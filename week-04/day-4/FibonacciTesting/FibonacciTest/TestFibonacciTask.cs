using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciTesting
{
    [TestFixture]
    class TestFibonacciTask
    {
        Program fibProgram = new Program();

        [TestCase]
        public void TestFibonacciWithNumber()
        {
            Assert.AreEqual(34, fibProgram.FibonacciForTesting(2));
        }
    }
}
