using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = firstNumber + secondNumber;
            int userResult = 0;

            Console.WriteLine();

            Console.Write("Enter your answer: ");
            userResult = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (result != userResult)
            {
                if (result != userResult)
                {
                    Console.WriteLine("Nope, you guessed it wrong. Try again");
                    Console.Write("Enter your answer: ");
                    userResult = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Well done!, You got the answer");

            Console.ReadLine();

        }
    }
}
