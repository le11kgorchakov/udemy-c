using System;

namespace JaggedArray
{
    internal class Methods
    {
        public string[][] jaggedHumanArray = new string[][]
         {
                new string []{"Bob","Ben","Biden"},
                new string []{"Mary", "Matt","Mark"},
                new string []{"Derek","Dima","Den"}
         };

        public void Introduce()
        {
            for (int i = 0; i < jaggedHumanArray.Length; i++)
            {
                Console.Write("Row {0}:", i);
                for (int j = 0; j < jaggedHumanArray[i].Length; j++)
                {
                    Console.Write(" {0} ", jaggedHumanArray[i][j]);
                }
            }
        }

        public int[] studentsGrades = new int[] { 12, 11, 15, 18, 15, 12, 16 };

        public double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}