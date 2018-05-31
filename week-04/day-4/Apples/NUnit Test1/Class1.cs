using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Apples;

namespace NUnitTest1
{
    [TestFixture]
    public class TestOutput
    {
        [TestCase]
        public void TestIfReturnOutputSameAsInput()
        {
        Assert.AreEqual(Apple.GetApple(), "apple");
        }
    }
}
