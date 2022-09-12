using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //abstract class 
    public abstract class Person
    {
        //properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //abstract method
        public abstract void sayName();
    }
}