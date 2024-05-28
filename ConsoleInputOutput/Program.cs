using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            String name = Console.ReadLine();

            Console.Write("Where do you work: ");
            String work = Console.ReadLine();

            Console.Write("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Hey, " + name + ". Wow! " + work + " is a great place to work");
            Console.Write("Congratulations on becoming " + age + " years old");


            Console.ReadLine();
        }
    }
}
