using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace Sum
{
    [TestFixture]
    public class TestSum
    {
        [TestCase]
        public void ShouldReturnTheSumOfIntegers()
        {
            Sum first = new Sum();
            List<int> testNumbers = new List<int>() {5, 10, 5, 7, 3, 13};
            Assert.AreEqual(first.SumNums(testNumbers), 43);
        }

    }
}
