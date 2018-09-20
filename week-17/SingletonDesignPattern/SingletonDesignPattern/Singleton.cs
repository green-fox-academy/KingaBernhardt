using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value" + counter.ToString());
        }
        public void PringDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
