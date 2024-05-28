using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            age++;
            Console.WriteLine(age);

            int salary = 2000;
            int newSalary = salary - 100;
            Console.WriteLine(newSalary);

            Console.WriteLine(salary * age);
            Console.WriteLine(salary / age);
            Console.WriteLine(salary % age);

            Console.ReadLine();
        }
    }
}
