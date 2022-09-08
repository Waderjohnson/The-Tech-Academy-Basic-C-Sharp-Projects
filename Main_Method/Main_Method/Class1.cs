using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    //class Math
    class Math
    {
        //public int method named addition taking in two parameters, both being int values.  If a second value is not passed in, it will automaticly equal 0.  an addition calculation is done with 
        // the two values passed in and the rusult is saved to the variable donemath and then returned as the result of the addition method.
        public int addition(int num1, int num2 = 0)
        {
            int donemath = num1 + num2;
            return donemath;
        }
    }
}