using System;
using System.Collections.Generic;
using System.Text;

namespace IPrintable
{
    internal class Domino : IPrintable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
    
        public string PrintAllFields()
        {
            return Values + "these are the sides of the domino.";
        }
    }
}
