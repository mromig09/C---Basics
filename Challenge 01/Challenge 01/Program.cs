﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine();

            Console.WriteLine("What month were you born?");
            var month = Console.ReadLine();
            Console.WriteLine("You were born in: {0}", month);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
