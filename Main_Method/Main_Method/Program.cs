using System;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the Class DoMath
            DoMath doMath = new DoMath();

            //Calling the mathod and its overflows from the class in a WriteLint method that will display the returned result of the what the method code returns.  In this case the answers to 
            //addition, subtraction and multiplication calculations.  Each method passing in a different value.  An int for the first called method, a decimal for the second and a string
            //for the third.  The string is converted to an int and returned as an int value.
            Console.WriteLine("111 + 3 = " + doMath.addition(3));
            Console.WriteLine(".66 - .315 = " + doMath.addition(.66m));
            Console.WriteLine("65 * 35 = " + doMath.addition("65"));
            Console.ReadLine();
        }
    }
    }