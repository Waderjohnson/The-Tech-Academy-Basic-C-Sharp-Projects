using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class of DoMath
            Math Math = new Math();

            //two variable representing inputs from the user
            int input1 = 0;
            int optionalinput = 0;


            //a WriteLine method printing to the console a request for an int saving the input to the variable input1
            Console.WriteLine("Please enter a number");
            input1 = Convert.ToInt32(Console.ReadLine());

            //a WriteLine method printing to the consol a request for an int with the possibility of leaving it blank.
            Console.WriteLine("Please enter a number if you would like one more.\n  Leave blank and press enter if not.");

            //a bool variable holding a value of true or false from a TryParse method to check if the input was succesfuly converted to an int value.
            bool isnum = int.TryParse(Console.ReadLine(), out optionalinput);
            //if isnum = false, optionalinput = 0,  if the previouse TryParse was able to convert a string to an int value, the value was saved to the variable optionalinput
            if (!isnum)
            {
                optionalinput = 0;
            }

            //if optionalinput = 0 the following WriteLine method will print to the consol the result of the method addition in the doMath class with 1 value passed in.  The result of the 
            //calculation being returned concatinated into the Writeline.
            if (optionalinput == 0)
            {
                Console.WriteLine("You entered one number. " + input1 + " + nothing = " + Math.addition(input1));
            }
            //else if two values were provided, both values were passed to the method addition for an addition calculation to be performed with the result being return can concatinated into the 
            //WriteLine method
            else
            {
                Console.WriteLine("You entered two numbers. " + input1 + " + " + optionalinput + " = " + Math.addition(input1, optionalinput));
            }

            Console.ReadLine();
        }
    }
}