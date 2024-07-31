using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<String, String> teachers = new Dictionary<String, String>
            {

                {"Math", "Fahim" },
                {"Physics", "Pranto" },
                {"Architeture", "Siyam" },
                {"Medical", "Nafi" },
                {"CSE", "Sayem" },
                {"Agricultural", "Arif" },

            };

            if (teachers.TryGetValue("Math", out String teacher))
            {

                Console.WriteLine(teacher);

            }
            else {
                Console.WriteLine("Teacher not found");
            }

            foreach (String key in teachers.Keys) { Console.WriteLine(key); }



            Console.ReadLine();
        }
    }
}
