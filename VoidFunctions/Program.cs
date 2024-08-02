using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your name: ");
            String name = Console.ReadLine();

            Welcome(name);


            Console.ReadLine();

        }

        static void Welcome(String name)
        {
            Console.WriteLine($"Hey {name}, Welcome to the code");
                
        }

       
    }
}
