using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = 100;
            int secondNumber = 9;

            Console.WriteLine(firstNumber % secondNumber);


            firstNumber = 20;
            secondNumber = 5;

            Console.WriteLine(firstNumber % secondNumber);


            Console.ReadLine();

        }
    }
}
