using System;
using System.Collections.Generic;
using System.Text;

namespace SharpieSet
{
    class SharpieSet
    {
        public List<Sharpie> sharpies = new List<Sharpie>();

        public string CountUsable()
        {
            int count = 0;
            foreach (var item in sharpies)
            {
                if (item.inkAmount > 0)
                {
                    count++;
                }
            }
            return "There are " + count + " usable sharpies left.";
        }
        public string RemoveTrash()
        {
            int amountRemoved = 0;
            for (int i = 0; i < sharpies.Count; i++)
            {
                if (sharpies[i].inkAmount <= 0)
                {
                    amountRemoved++;
                    sharpies.RemoveAt(i);
                }
            }
            return "There is " + amountRemoved + " from the sharpie set.";
        }
    }
}
