using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Fahim";
            String number = "01764014518"; //the reason why storing number as an int coz the compiler doesn't recognizes 0 in the begining of any number
            int age = 24;
            var salary = "2000";

            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(age);
            Console.WriteLine(salary);

            Console.ReadLine();
        }
    }
}
