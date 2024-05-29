using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an amount you want to invest: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = year * 12;

            int interest = 9;

            Double income = (amount * month) * interest / 100;

            Double finalReturn = income + (amount * month);

            if (finalReturn <= 150000 && finalReturn == 0)
            {
                Console.WriteLine(finalReturn);
                Console.WriteLine("You will not get a good return!");
            }
            else
            {
                Console.WriteLine(finalReturn);
                Console.WriteLine("You will get a good return!");
            }

            Console.ReadLine();

        }
    }
}
