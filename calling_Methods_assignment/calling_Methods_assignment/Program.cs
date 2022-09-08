using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_Methods_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Created a class called mathClass to contain methods for math computation.
            MathClass mathClass = new MathClass();

            //a Writeline method printing to the console a question for the user to make a input.  The input being saved to the variable inputnumber.  The variable inputnumber is also applied to
            //public int inputnumber { get; set; } in the MathClass as a global paramater for all the methods in the class.
            Console.WriteLine("Please give a number to be used in three mathematical calculations against the number 55 with a bonus figure\n of the square root of the number you choose.");
            mathClass.inputnumber = Convert.ToInt32(Console.ReadLine());

            //calls for the methods subMath, addMath, multiMath.
            mathClass.subMath(mathClass.inputnumber);
            mathClass.addMath(mathClass.inputnumber);
            mathClass.multiMath(mathClass.inputnumber);

            //A WriteLine method printing to the console a statement containing the class parameter and the return value from the method sqrtMath concatinated into the statement.
            Console.WriteLine("The Square root of " + mathClass.inputnumber + " is " + mathClass.sqrtMath(mathClass.inputnumber));


            Console.ReadLine();
        }
    }
}
