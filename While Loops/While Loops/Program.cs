using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "";
            while (username != "mark")
            {
                Console.WriteLine("What is your Username:");
                username = Console.ReadLine();

                if (username != "mark")
                {           
                    Console.WriteLine("Username is Incorrect");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Username is Correct");


            var password = "";

            while (password != "secret")
            {
                Console.WriteLine("What is your Password:");
                password = Console.ReadLine();

                if (password != "secret")
                {
                    Console.WriteLine("Password is incorrect!!");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Password is Correct!!");

            Console.ReadKey();
        }
    }
}
