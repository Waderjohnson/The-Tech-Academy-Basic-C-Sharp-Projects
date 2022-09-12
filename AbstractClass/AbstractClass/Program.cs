using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an Employee object
            Employee employee1 = new Employee();

            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.sayName();

            Console.ReadLine();
        }
    }
}