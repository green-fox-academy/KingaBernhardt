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
        public void TestIfCardIsTwo(string input)
        {
            string output = poker.GetValue(input);
            Assert.AreEqual("2", output);
        }

        [TestCase]
        public void TestIfCardIsEleven(string input)
        {
            string output = poker.GetValue(input);
            Assert.AreEqual("J", output);
        }

        [TestCase]
        public void GetHands()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            string output = poker.GetHands(input);
            Assert.AreEqual("White wins", output);
        }


    }
}
