using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace calling_Methods_assignment
{
    public class MathClass
    {
        //the class parameter value from the input variable inputnumber.
        public int inputnumber { get; set; }

        //a method for doing subtraction with the value of the parameter input number applied to the variable num. num - 55 = value saved to the variable subtraction. With a console writeline 
        //to display a statement showing the operation with the value of num and subtraction concatenated into the statement.
        //an if statement applied to avoid a negative number from subtracting a smaller number than 55
        public void subMath(int num)
        {
            if (num >= 55)
            {
                int subtraction = num - 55;
                Console.WriteLine("Subtraction: " + num + " - 55 = " + subtraction);
            }
            else
            {
                int subtraction = 55 - num;
                Console.WriteLine("Subtraction: 55 - " + num + " = " + subtraction);
            }
        }

        //a method for doing addition with the value of the parameter input number applied to the variable num. num + 55 = value saved to the variable addition. With a console writeline 
        //to display a statement showing the operation with the value of num and addition concatenated into the statement.
        public void addMath(int num)
        {
            int addition = num + 55;
            Console.WriteLine("Addition: " + num + " + 55 = " + addition);
        }

        //a method for doing multiplication with the value of the parameter input number applied to the variable num. num * 55 = value saved to the variable multiplication. With a console writeline 
        //to display a statement showing the operation with the value of num and multiplication concatenated into the statement.
        public void multiMath(int num)
        {
            int multiplication = num * 55;
            Console.WriteLine("Multiplication: " + num + " * 55 = " + multiplication);
        }

        //a method for finding the square root with the value of the parameter input number applied to the variable num. utilizing the system Math class with the method Sqrt of the variable sum
        //= value saved to the variable sqrt. This method makes a return value to the method that will used in a Writeline methode statement (mathClass.sqrtMath(mathClass.inputnumber) concatinated
        //into the statement )
        public double sqrtMath(int num)
        {
            double sqrt = Math.Sqrt(num);
            return sqrt;
        }
    }
}
