using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PringDetails("This is message from employee");
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PringDetails("This is message from student.");
            Console.ReadLine();
        }
    }
}
