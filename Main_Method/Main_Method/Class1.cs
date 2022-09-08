using System;
using System.Collections.Generic;
using System.Text;

namespace Main_Method
{
    class DoMath
    {
        //a public method that performs an addition calulation from a value passed in from the method call.  The method returns the value from the addition calculation.
        public int addition(int num)
        {
            int doneMath = num + 111;
            return doneMath;
        }
        //a overflow method that performs a subtraction calulation from a value passed in from the method call.  The method returns the value from the subtraction calculation.
        public decimal addition(decimal dec)
        {
            decimal doneMath = dec - .315m;
            return doneMath;
        }
        //a overflow method that performs an multiplication calulation from a value passed in from the method call.  The value passed in as a string is converted within the method
        //to an int and returns an int value. The method returns the value from the multiplication calculation.
        public int addition(string aString)
        {
            int number = Convert.ToInt32(aString);
            int doneMath = number * 35;
            return doneMath;
        }
    }
}
