using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introductory_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if(name == "")
            {
                WriteTryAgain();
                name = Console.ReadLine();
            }

            Console.WriteLine("\nWhat is your age?");
            var age = Console.ReadLine();

            if (age == "")
            {
                WriteTryAgain();
                age = Console.ReadLine();
            }

            Console.WriteLine("\nWhat month were you born?");
            var month = Console.ReadLine();

            if (month == "")
            {
                WriteTryAgain();
                month = Console.ReadLine();
            }

            Console.WriteLine("\nYour name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if(month == "march")
            {
                Console.WriteLine("You are an Aries.");
            }

            else if (month == "april")
            {
                Console.WriteLine("You are a Taurus.");
            }

            else if (month == "may")
            {
                Console.WriteLine("You are a Gemini.");
            }

            Console.ReadKey();
        }

        static void WriteTryAgain()
        {
            Console.WriteLine("You didn't write anything, Please try again:\n");
        }
    }
}
