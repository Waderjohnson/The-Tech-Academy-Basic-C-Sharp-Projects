using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //inherit from the Person class
    public class Employee : Person
    {
        ////Implement the SayName() method inside of the Employee class
        public override void sayName()
        {
            Console.WriteLine("Employee name is: " + firstName + " " + lastName);
        }

    }
}