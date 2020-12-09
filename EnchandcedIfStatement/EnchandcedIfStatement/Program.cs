using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnchandcedIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 103;

            /*    if(age <= 21 && age >= 15)
              {
                  Console.WriteLine("teenager");
              }
              else if(age > 21 && age < 60){
                  Console.WriteLine("adult");
              }
              else
              {
                  Console.WriteLine("senior");
              } */
            string ageType;

            ageType = age <= 21 && age >= 15 ? "teen" : ageType = age > 21 && age < 60 ? "adult" : "senior"; 


                Console.WriteLine("you are {0}", ageType);
                
                Console.Read();
        }
    }
}
