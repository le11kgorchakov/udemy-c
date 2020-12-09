using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program 
    {
        static string userName;
        static string login;
        static string password;

        static void Main (string[] args)
        {
            Register();
            Login();
            Console.Read();
        }


        public static void Register()
        {
            Console.WriteLine("please enter your user name: ");
            userName = Console.ReadLine();
            Console.WriteLine("please enter your login: ");
            login = Console.ReadLine();
            Console.WriteLine("please enter your password: ");
            password = Console.ReadLine();
        }

        public static void Login()
        {
            Console.WriteLine("please login in to the system: Enter your user name ____  ");
            if (userName == Console.ReadLine())
            {
                Console.WriteLine("please enter you login ___ ");
                if (login == Console.ReadLine())
                {

                    Console.WriteLine("you are almost there ____");
                }
            }
        }
    }
}
