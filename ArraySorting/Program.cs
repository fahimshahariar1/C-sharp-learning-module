using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[] { 5,8,1,9 };

            Array.Sort(numbers);

            foreach (int i in numbers) {

                Console.WriteLine(i);
            }

             

            Console.ReadLine();

        }
    }
}
