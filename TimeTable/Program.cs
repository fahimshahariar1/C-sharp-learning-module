using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("The table for the number {0} is", num);
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine("{0} x {1} = {2}",i, num,  i*num);

            }
            Console.ReadLine();

        }
    }
}
