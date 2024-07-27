using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 1; i <= 15; i++)
            {
                bool threediv = i % 3 == 0;   // for better readibility and if the condition changes to divide by other number we
                bool fivediv = i % 5 == 0;   //can simply chnage it here. we won't have to change in everywhere

                if (threediv && fivediv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threediv)
                {
                    Console.WriteLine("Fizz");

                }
                else if (fivediv)
                {
                    Console.WriteLine("Buzz");

                }
                else { Console.WriteLine(i); }

            }
            Console.ReadLine();

        }
    }
}
