using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayofMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 7;
            int length = 5;
            int counter = 0;

            int[] result = new int[length];

            for (int i = 1; i <= result.Length; i++, counter++)
            {
                result[counter] = num * i;
               
            }

            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }

            Console.ReadLine();

        }
    }
}
