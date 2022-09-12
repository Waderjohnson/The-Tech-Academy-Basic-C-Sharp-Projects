using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmissionAssignment
{
    public class Employee: Person

    {
        public int employeeID { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Hello, my name is {0} {1}", firstName, lastName);
        }

        public int Id { get; set; }
        //overload for the == operator comparing two properties
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //overload for the != operator comparing two properties
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.Id != emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }




}