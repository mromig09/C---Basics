﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {


            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;

            while (adding)
            {
                Console.Write("Student Name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write("Student Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("\nAdd another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("\nName: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }

            Console.ReadKey();
        }
    }
}
