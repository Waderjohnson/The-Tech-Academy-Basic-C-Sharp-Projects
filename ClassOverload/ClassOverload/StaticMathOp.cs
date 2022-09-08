using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOverload
{
    public static class StaticMathOp
    {
        //using out parameter 
        public static int MethodMult(int userNum)
        {
            int returnNum = userNum * 5;
            return returnNum;
        }
    }
}