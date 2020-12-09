using System;

namespace ForLoop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            So he wants to be able to enter each score
            individually and then get the final average
            score once he enters -1.
            So the tool should check if the entry is a number and
            should add that to the sum. Finally once he is
            done entering scores, the program should write onto the console what the average score is.
            The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if
            the teacher enters an incorrect value.
            Test your program thoroughly.
             */
            //take input from user for each students
            string[] students = new string[] { "Oleg", "Victor", "Dima", "Ula" };

            int[] score = new int[students.Length];

            double sum = 0;
            int i = 0;
            while (students.Length > i)
            {
                int temp;
                Console.WriteLine("enter {0} score ", students[i]);
                score[i] = int.TryParse(Console.ReadLine(), out temp) ? temp : 0;

                sum += score[i];
                i++;
            }
            Console.WriteLine(sum / students.Length);
            Console.Read();
        }
    }
}