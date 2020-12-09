using System;

namespace OOP_Human
{
    internal class Human
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public void Inrtoduce()
        {
            if (age == 0)
            {
                Console.WriteLine("Hello my name is {0} my last name is {1} i have a {2} eyes", firstName, lastName, eyeColor);
            }
            else if (age != 0)
            {
                Console.WriteLine("Hello my name is {0} my last name is {1} i have a {2} eyes and im {3} years old", firstName, lastName, eyeColor, age);
            }

            Console.Read();
        }
    }
}