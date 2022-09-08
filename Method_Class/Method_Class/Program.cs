using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the class Math
            Math math = new Math();

            //a call to the method in class math with int values being passed as the parameters.
            math.addition(45, 92);
            Console.ReadLine();
            //a call to the method in class math with the parameters set by name with thier values.
            math.addition(num1: 25, num2: 56);
            Console.ReadLine();
        }
    }
}