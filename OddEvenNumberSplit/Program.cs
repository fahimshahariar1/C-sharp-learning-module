using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenNumberSplit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list1 = new List<int>() 
            { 
            
            };

            List<int> list2 = new List<int>()
            {

            };

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0) 
                { 
                list1.Add(i);
                }
                else
                {
                    list2.Add(i);
                }

               
            }

            Console.WriteLine("Printing Even Numbers:");

            foreach (int i in list1)
            {
                Console.Write($"{i} ");
            }


            Console.WriteLine(Environment.NewLine+"Printing Odd Numbers:");

            foreach (int i in list2)
            {
                Console.Write($"{i} ");
            }


            Console.ReadLine();


        }
    }
}
