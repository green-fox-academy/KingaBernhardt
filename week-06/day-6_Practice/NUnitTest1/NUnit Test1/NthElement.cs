using NthElementTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NthElementTest
{
    public class NthElement
    {
        [TestFixture]
        public class Test
        {
            /**
            * Write your test cases here. You should be able to invoke the method like this:
            * double result = NthElement.GetAverageForNthElements(numbers, n);
            */

            [Test]
            public void GetAverageForNthElements_testCase1()
            {
                int[] numbers = new int[] { 2, 4, 10, 34, 3, 16, 3, 21 };
                int n = 3;
                double output = Program.GetAverageForNthElements(numbers, n);
                Assert.AreEqual(13, output);
            }

            [Test]
            public void GetAverageForNthElements_testCase2()
            {
                int[] numbers = new int[] { 2, 4, 10, 34, 3, 16, 3, 21 };
                int n = 10;
                double output = Program.GetAverageForNthElements(numbers, n);
                Assert.AreEqual(12, output);
            }
        }
    }
}

