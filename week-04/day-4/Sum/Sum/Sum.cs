using System;
using System.Collections.Generic;
using System.Text;

namespace Sum
{
    public class Sum
    {
        List<int> numbers = new List<int>() { 4, 6, 5, 5};
        public int SumNums(List<int> numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
}
