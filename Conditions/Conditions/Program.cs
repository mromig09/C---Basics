﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();          

            Console.WriteLine("What month were you born?");
            var month = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born in: {0}", month);

            if(month == "march")
            {
                Console.WriteLine("You are an Aries.");
            }

            else if(month == "april")
            {
                Console.WriteLine("You are a Taurus.");
            }

            else if (month == "may")
            {
                Console.WriteLine("You are a Gemini.");
            }
            Console.ReadKey();
        }
    }
}
