using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            String name = Console.ReadLine();

            Console.Write("What is your birth date: ");
            int birthDate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (birthDate <= 0 || birthDate >= 31)
            {
                Console.WriteLine("Enter a value above 0 and lower than 31");
            }
            else
            {
                for (int i = 0; i <= birthDate; i++)
                {
                    Console.WriteLine(name +" You are the best");
                }
            }

            Console.ReadLine();
        }
    }
}
