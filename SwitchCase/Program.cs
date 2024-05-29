using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number of the day of a week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.Write("Friday");
                    break;
                case 2:
                    Console.Write("Saturday");
                    break;
                case 3:
                    Console.Write("Sunday");
                    break;
                case 4:
                    Console.Write("Monday");
                    break;
                case 5:
                    Console.Write("Tuesday");
                    break;
                case 6:
                    Console.Write("Wednesday");
                    break;
                case 7:
                    Console.Write("Thursday");
                    break;

                default: Console.WriteLine("Invalid Inout");
                    break;


                    
            }
            Console.ReadLine();
        }
    }
}
