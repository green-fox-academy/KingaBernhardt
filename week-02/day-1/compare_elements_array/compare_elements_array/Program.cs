using System;

namespace compare_elements_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`

            int[] p1 = new int[] { 1, 2, 3 };
            int[] p2 = new int[] { 4, 5 };
            Console.WriteLine(CompareLength(p1, p2));
            Console.ReadLine();
        }

        public static bool CompareLength(int[] p1, int[] p2)
        {
            for (int i = 0; i < p1.Length; i++)
            {
                for (int j = 0; j < p2.Length; j++)
                {
                    if (p2.Length > p1.Length)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
