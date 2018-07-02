using NUnit.Framework;
using Poker_Dojo;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokerDojo
{
    [TestFixture]
    class PokerTest
    {
        PlayPoker poker = new PlayPoker();
        [TestCase]
        public void TestIfEnoughElement()
        {
            string input = "2H 3D 5S 9C KD 2C 3H 4S 8C AH";
            bool output = poker.CheckInputLenght(input);
            Assert.AreEqual(true, output);
        }

        [TestCase]
        public void TestIfCardIsTwo()
        {
            string input = "2";
            int output = poker.GetValue(input);
            Assert.AreEqual(2, output);
        }

        [TestCase]
        public void TestIfCardIsJack()
        {
            string input = "J";
            int output = poker.GetValue(input);
            Assert.AreEqual(11, output);
        }

        [TestCase("Q")]
        public void TestIfCardIsQueen(string input)
        {
            int output = poker.GetValue(input);
            Assert.AreEqual(12, output);
        }

        [TestCase("K")]
        public void TestIfCardIsKing(string input)
        {
            int output = poker.GetValue(input);
            Assert.AreEqual(13, output);
        }

        [TestCase("A")]
        public void TestIfCardIsAce(string input)
        {
            int output = poker.GetValue(input);
            Assert.AreEqual(14, output);
        }

        [TestCase("2C")]
        public void TestIfCardIsTwoC(string input)
        {
            int output = poker.GetMoreValue(input);
            Assert.AreEqual(2, output);
        }


    }
}
