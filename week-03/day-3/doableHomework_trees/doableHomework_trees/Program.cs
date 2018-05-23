using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace doableHomework_trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree treeFirst = new Tree("oak", "green", 50, "male");
            Tree treeSecond = new Tree("willow", "darkgreen", 40, "female");
            Tree treeThird = new Tree("maple", "orange", 45, "female");
            Tree treeFourth = new Tree("pine", "brown", 55, "male");
            Tree treeFiveth = new Tree("birch", "yellow", 20, "female");

            Console.WriteLine("The first tree is an " + treeFirst.name + " it is " + treeFirst.color + " it's age is " + treeFirst.age + " and it is a " + treeFirst.sex + ".");
            Console.ReadLine();
        }
    }
}
