using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your Password: ");
            String pass = Console.ReadLine();

            Console.Write("Enter Your Password Again: ");
            String passcheck = Console.ReadLine();

            if (passcheck.Equals(pass))
            {
                Console.WriteLine("Your password is correct");
            }
            else
            {
                Console.WriteLine("Your password is incorrect");
            }

            Console.ReadLine();
        }
    }
}
