using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciTesting
{
    [TestFixture]
    class TestFibonacciTask
    {
        Fib fibProgram = new Fib();

        [TestCase]
        public void TestFibonacciWithEight()
        {
            Assert.AreEqual(21, fibProgram.FibonacciForTesting(8));
        }

        [TestCase]
        public void TestFibonacciWithTwo()
        {
            Assert.AreEqual(4, fibProgram.FibonacciForTesting(2));
        }

        [TestCase]
        public void TestFibonacciWithNegative()
        {
            Assert.AreEqual(12, fibProgram.FibonacciForTesting(3));
        }

        [TestCase]
        public void TestFibonacciWithZero()
        {
            Assert.AreEqual(12, fibProgram.FibonacciForTesting(0));
        }
    }
}
