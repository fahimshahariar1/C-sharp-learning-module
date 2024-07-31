using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numberslist = new List<int>()
            { 
                 1,2,3,4,5,6 
            }; 

            numberslist.Add(1);
            Console.WriteLine(numberslist.Contains(2));
            
            //There are many other functions for the list


            foreach (int number in numberslist)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();

        }
    }
}
