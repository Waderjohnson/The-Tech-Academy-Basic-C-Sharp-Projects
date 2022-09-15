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
            //Instantiate new employee and set their name
            IQuittable person = new Employee() { FirstName = "Sample", LastName = "Student" };

            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            person.Quit();
        }
    }
}
