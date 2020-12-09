using System;
using System.Collections;

namespace arraysLists
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList myArrList = new ArrayList();

            ArrayList myArrLists = new ArrayList(100);

            myArrList.Add(25);
            myArrList.Add("Hey");
            myArrList.Add(23.344);
            myArrList.Add(144565);
            myArrList.Add(65);

            // delete element with specific value from arr list
            //myArrList.Remove(25);
            // delte element by index
            //myArrList.RemoveAt(2);

            void ArraySum(ArrayList arralist)
            {
                double sum = 0;
                foreach (object e in myArrList)
                {
                    if (e is int)
                    {
                        sum = +Convert.ToDouble(e);
                    }
                    else if (e is double)
                    {
                        sum = +(double)e;
                    }
                    else if (e is string)
                    {
                        Console.WriteLine(e);
                    }
                }
                Console.WriteLine(myArrList.Count);
                Console.WriteLine(sum);
            }
            ArraySum(myArrList);
            Console.Read();
        }
    }
}