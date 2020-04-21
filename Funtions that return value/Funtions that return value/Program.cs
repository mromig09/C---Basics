using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funtions_that_return_value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            if (name == "")
            {               
                name = TryAgain();
            }

            Console.WriteLine("\nWhat is your age?");
            var age = Console.ReadLine();

            if (age == "")
            {
                age = TryAgain();
            }

            Console.WriteLine("\nWhat month were you born?");
            var month = Console.ReadLine();

            if (month == "")
            {
                month = TryAgain();
            }

            Console.WriteLine("\nYour name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            if (month == "march")
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

        static string TryAgain()
        {
            Console.WriteLine("You didn't write anything, Please try again:\n");
            return Console.ReadLine();
        }
    }
}
