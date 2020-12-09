using System;
using System.Collections.Generic;

namespace ImmutableArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> myList = new List<int>
            {
                1,2,3,4,5,6,7,21,33,4,5342,232,12
            };

            void DisplayArray(List<int> arr)
            {
                foreach (int e in arr)
                {
                    Console.Write(" {0}", e);
                }
                Console.Read();
            }

            int index = myList.FindIndex(x => x == 6);
            Console.WriteLine(index);

            myList.ForEach(i => Console.WriteLine(i));

            Console.Read();
        }
    }
}