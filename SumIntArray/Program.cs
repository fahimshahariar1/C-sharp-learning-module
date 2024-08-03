using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumIntArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 5};

            int result = SumofNumbers(numbers);

            /*if (result > -1)
            {
                Console.WriteLine($"The total is: {result}");
            }
            else
            {
                Console.WriteLine("The array can not be empty");
            }*/


            if (SumofNumbers(numbers, out int total))
            {
                Console.WriteLine($"The total is: {total}");

            }
            else
            {
                Console.WriteLine("The array can not be empty");
            }




            Console.ReadLine();

        }

        static int SumofNumbers(int[] numbers)
        {

            if (numbers.Length > 0)
            {
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }

            return total;

            }

            return -1;

        }


        static bool SumofNumbers(int[] numbers, out int total)
        {

            total = 0;

            if (numbers.Length > 0)
            {
              

                foreach (int number in numbers)
                {
                    total += number;
                }

                return true;

            }

            return false;

        }

    }

}
