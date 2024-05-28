using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varConst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var is used when you do not define any datatype of a variable

            var age = 24; //here despite not using the int datatype specified it assigned the value as int based on the value

            //similarly
            var name = "Fahim"; // it can work for any datatype

            //const is something that is used when you don't want a particular value to change ever 

            const int salary = 20000;

            int salary = 20; //the red line shows that the value can not be changed for that particular variable
        }
    }
}
