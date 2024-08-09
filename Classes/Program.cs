using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        //Classes are like structres but with more flexibility
        //it is recommended to use classes for better usability
        class Person
        {
            public int Id;
            public string Name;

            public Person(int id, string name)
            {
                Id = id;
                Name = name;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is Your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your Ding ID?");
            int id = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(id, name);

            if (string.IsNullOrEmpty(person.Name)) 
            {
                Console.WriteLine("Name can not be empty!");

            }
            else
            {
                Console.WriteLine($"Hello {person.Name}. Your Ding ID is {person.Id}" );
            }

            Console.ReadLine();

        }
    }
}
