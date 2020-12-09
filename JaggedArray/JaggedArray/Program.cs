using System;

namespace JaggedArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Methods M = new Methods();
            /*
            int[][] jaggedArray = new int[][] {
                new int []{2,4,5,763,4,24},
                new int []{3,5,7,3}
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row {0}:", i);
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(" {0} ", jaggedArray[i][j]);
                }
            }
            */

            //M.Introduce();
            Console.Write(M.GetAverage(M.studentsGrades));
            foreach (int e in M.studentsGrades)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }
    }
}