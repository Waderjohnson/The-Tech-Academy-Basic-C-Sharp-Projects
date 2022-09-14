using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee IQuittable = new Employee();
            IQuittable.FirstName = "Sample";
            IQuittable.LastName = "Student";
            IQuittable.SayName();

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            IQuittable.Quit();

            Console.ReadLine();
        }
    }
}
