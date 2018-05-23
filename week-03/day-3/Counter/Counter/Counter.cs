using System;
using System.Collections.Generic;
using System.Text;

namespace Counter
{
    class Counter
    {
        public int firstStatus = 0;
        public int result;
        public string stringOfResult;

        public int Add(int numberAdd)
        {
            int result = firstStatus + numberAdd;
            return result;
        }
        public string Get(int result)
        {
            string stringOfResult = Convert.ToString(result);
            return stringOfResult;
        }
        public int Reset()
        {
            return firstStatus;
        }
    }
}
