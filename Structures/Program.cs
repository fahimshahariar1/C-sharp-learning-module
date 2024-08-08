using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Structures
{
    internal class Program
    {
        struct Person
        {
            public int Id;
            public string Name;  //set to public so that it can be accessible from anywhere

            public Person(int id, string name)
            {
                this.Id = id;
                this.Name = name;
            }
        }

        static void Main(string[] args)
        {
            CreatePerson();

            Console.ReadLine();
        }

        static void CreatePerson()
        {
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Ding ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Person person2 = new Person(id, name);

            Console.WriteLine($"Hello {person2.Name}. Your ID is {person2.Id}");
        }
    }
}

