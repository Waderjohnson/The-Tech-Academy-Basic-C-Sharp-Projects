using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndObjects
{
    class Person
    {
        //person name definition 
        public string firstName { get; set; }
        public string lastName { get; set; }

        //method to display persons first and last name 
        public void sayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
