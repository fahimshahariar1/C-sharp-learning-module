using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {



            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter numbers only");
                throw;
            }
            catch (OverflowException)
            {

                Console.WriteLine("Enter Number less than 2 billion");

            }
            catch (Exception) 
            {

                Console.WriteLine("Wrong Input");

            }


            Console.ReadLine();


        }
    }
}
