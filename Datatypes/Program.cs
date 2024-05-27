using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            float salary = 31350.00F;

            Console.WriteLine(age);
            Console.WriteLine(salary);

            String name = "Fahim";
            char letter = 'S';

            Console.WriteLine("My name is ", name);
            Console.WriteLine("I am ", age, "years old");
            Console.WriteLine("My salary is ", salary);
            Console.WriteLine("And my favourite character is ", letter);

           

            //to convert numbers to strings and vice versa

            String fahimage = "24";
            int realage = Convert.ToInt32(fahimage);
            Console.WriteLine(realage);

            Console.ReadLine();
        }
    }
}
