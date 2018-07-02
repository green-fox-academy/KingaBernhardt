﻿using NUnit.Framework;
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
        public void TestIfCardIsEleven()
        {
            string input = "J";
            int output = poker.GetValue(input);
            Assert.AreEqual(11, output);
        }

        [TestCase("D")]
        public void TestIfCardIsTwelve(string input)
        {
            int output = poker.GetValue(input);
            Assert.AreEqual(12, output);
        }

        [TestCase("K")]
        public void TestIfCardIsThirty(string input)
        {
            int output = poker.GetValue(input);
            Assert.AreEqual(13, output);
        }


    }
}