using System;
using System.Collections.Generic;
using System.Text;

namespace CompareTo
{
    class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int CompareTo(Domino domino)
        {
            return this.GetValues()[0].CompareTo(domino.GetValues()[0]);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", GetValues()[0],GetValues()[1]);
        }

        public int[] GetValues()
        {
            return Values;
        }

    }
}
