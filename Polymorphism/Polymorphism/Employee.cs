using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //Create another class called Employee and have it inherit from the Person class
    public class Employee : Person, IQuittable
    {
        public int id { get; set; }

        public void Quit()
        {
            Console.WriteLine("Employee is quitting.");
        }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
