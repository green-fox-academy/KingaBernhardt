using System;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog myBlog = new Blog();
            BlogPost healthyEating = new BlogPost("Kinga Bernhardt", "How to eat healthy", "Vegetables and fruits in a smoothie", "2018.05.26");
            BlogPost outdoor = new BlogPost("July Ham", "Have fun", "The greatness of being outdoors", "2016.02.21");
            myBlog.Delete(3);
            myBlog.Update(4, healthyEating);
            myBlog.PrintOutTheBlog();
            Console.ReadLine();
        }
    }
}
