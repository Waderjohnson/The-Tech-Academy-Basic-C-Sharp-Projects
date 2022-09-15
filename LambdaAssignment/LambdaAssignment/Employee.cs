using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAssignment
{
    class Employee
    {
        //public variable for the blueprint of the list
        public int _Id;
        public string _firstName;
        public string _lastName;

        //method for taking in values for creating a list returning the values from each paramater passed to the method
        public Employee(int Id, string firstName, string LastName)
        {
            _Id = Id;
            _firstName = firstName;
            _lastName = LastName;
        }




    }
}