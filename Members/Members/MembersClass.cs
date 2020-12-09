using System;
using System.Diagnostics;

namespace Members
{
    internal class MembersClass
    {
        private string memberName;
        private string jobTitle;
        private int salary;

        public int age;

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }

        public void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

        public MembersClass()
        {
            age = 30;
            memberName = "Nina";
            salary = 120000;
            jobTitle = "dev";
            Console.WriteLine("object is created");
        }

        ~MembersClass()
        {
            //clean up statement
            Console.WriteLine("deconstruction of a MembersClass object");
            Debug.Write("destruction of a MembersClass object");
        }
    }
}