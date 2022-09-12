using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Employee name is: {0} {1}", FirstName, LastName);
        }

        public void Quit()
        {
            Console.WriteLine("This employee has quit");
            FirstName = "";
            LastName = "";
        }
    }
}