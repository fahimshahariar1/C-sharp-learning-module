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

            Console.WriteLine();

            Console.Write("Enter Number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers, search); 

            if (position > -1) {
                
                Console.WriteLine("Number Has been found");
            }
            else
            {
                Console.WriteLine("Number has not been found");
            }

             

            Console.ReadLine();

        }
    }
}
