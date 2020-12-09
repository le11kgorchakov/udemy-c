using System;

namespace Inheritance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Post myFirstPost = new Post("Alexey", "this is my first post", true);
            Console.WriteLine(myFirstPost.ToString());

            Post mySecondPost = new Post("Petr", "this is my first post", true);
            Console.WriteLine(mySecondPost.ToString());

            Console.Read();
        }
    }
}