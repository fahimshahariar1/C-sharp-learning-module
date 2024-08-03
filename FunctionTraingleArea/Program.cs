using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTraingleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            double width = ReadInt("Enter Width: ");

            
            double height = ReadInt("Enter Height: ");

            Console.Write($"The Area of triangle is: {Area(width, height)}");



            Console.ReadLine();


        }

        static int ReadInt(String message) 
        {

            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        
        }



        static double Area(double width, double height)
        {

            return 0.5 * width * height;

        }

    }
}
