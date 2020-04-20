using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge___Password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username:");
            var username = Console.ReadLine();

            Console.WriteLine("Password:");
            var password = Console.ReadLine();

            if (password == "secret")
            {
                Console.WriteLine("That's Correct!!");
            }

            else if (password != "secret")
            {
                Console.WriteLine("That is incorrect!!");
            }

            Console.ReadKey();
            
        }
    }
}
