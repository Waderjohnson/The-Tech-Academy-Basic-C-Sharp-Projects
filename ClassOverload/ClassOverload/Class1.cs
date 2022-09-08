using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOverload
{
    public class MathOp
    {
        //void: division operation
        public void myMethodOp(int userNum)
        {
            Console.WriteLine("Your number divided by two is: " + (userNum / 2));
        }

        //static: addition operation
        public static int myMethodOp(int userNum, int myNum)
        {
            int newNum = userNum + myNum;
            return newNum;
        }

        //using out parameter 
        public void MethodOut(int userNum, out int extraNum)
        {
            extraNum = userNum + 12;

        }

    }
}