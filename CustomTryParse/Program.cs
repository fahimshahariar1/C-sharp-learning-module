using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool success = false;
            
            try
            {
                Console.Write("Enter Number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
               
            }

            Console.WriteLine(success ? "Yay" : "Oh no!");

            Console.ReadLine();
        }

        static bool TryParse(String input, out int result)
        {

            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
    }
}
