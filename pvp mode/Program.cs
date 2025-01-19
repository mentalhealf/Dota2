using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvp_mode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte age = 12;
            string name = "Alex";
            double grade = 11.3;
            char favSymb = '$';
            bool isSmart = true;

            Console.WriteLine("Hello, my name is {0} i'm {1} years old", name, age);
            Console.WriteLine("I have avrage grade - {0}, grade");
            Console.WriteLine("What is your name?");
            Console.Write("My name is...");

            string myName = Console.ReadLine();

            Console.WriteLine("Thats cool how old are you");
            Console.Write("Im....");

            byte myAge = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("So your name is {0} and your {1} years old that is cool", myName, myAge);

            Console.ReadKey();


        }
    }
}
