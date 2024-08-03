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
            String userName = Console.ReadLine();

            Welcome(userName);


            Console.ReadLine();

        }

        //We can create other functions or methods to make the code readble and more reusable
        static void Welcome(String name)
        {
            Console.WriteLine($"Hey {name}, Welcome to the code");
                
        }

       
    }
}
