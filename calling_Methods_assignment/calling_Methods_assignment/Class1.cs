using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Methods
    {
        //a method for doing addition with the value of the parameter input number applied to the variable num. num + 55 = value saved to the variable addition. With a return to return value to calling method.
        public static int addInt(int num)
        {
            int myNum = num;
            int myNumAdd = myNum + 55;
            return myNumAdd;
        }
        //a method for doing subtraction with the value of the parameter input number applied to the variable num. num - 55 = value saved to the variable subtraction. With a return to return value to calling method.

        public static int subInt(int num)
        {
            int myNum = num;
            int myNumSub = myNum - 55;
            return myNumSub;
        }

        //a method for doing multiplication with the value of the parameter input number applied to the variable num. num * 55 = value saved to the variable multiplication. With a return to return value to calling method.
        public static int multInt(int num)
        {
            int myNum = num;
            int myNumMult = myNum * 55;
            return myNumMult;
        }
    }
}
