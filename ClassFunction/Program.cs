using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunction
{
    internal class Program
    {
        class Person
        {
            public int Id;
            public string Name;

            public Person(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }

           

            public string ReturnDetails()
            {
               return $"Hi, {Name}, Your Id is {Id}";
            }

        }
        static void Main(string[] args)
        {

            Person person = new Person(1031, "Fahim");

            Console.WriteLine(person.ReturnDetails());

            Console.ReadLine();

        }
    }
}
