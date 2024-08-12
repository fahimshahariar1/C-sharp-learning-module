using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFields
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

            public void SetName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                {
                    this.Name = name;
                }
                else
                {
                    this.Name = "Invalid Name";
                }
            }

            //Rather than using Get set differently we can use the default auto implemented properties recommended by C# 

            public string GetName()
            { return this.Name; }



            public void SetId(int id)
            {
                if (this.Id != id)
                {
                    this.Id = id;
                }
                else { this.Id = 0; }
            }

            public int GetId()
            { return this.Id; }

          



            public string ReturnDetails()
            {
                return $"Hi, {Name}, Your Id is {Id}";
            }

            public override string ToString()
            {
                return $"Hi, {Name}, Your Id is {Id}";
            }

        }
        static void Main(string[] args)
        {

            Person person = new Person(1031, "Fahim");
            Console.WriteLine(person.ReturnDetails());

            Console.WriteLine(person.ToString());

            person.SetName("");
            person.SetId(1);

            Console.WriteLine();
            Console.WriteLine($"Your name is {person.GetName()} & ID is {person.GetId()}");

            Console.ReadLine();

        }
    }
}

