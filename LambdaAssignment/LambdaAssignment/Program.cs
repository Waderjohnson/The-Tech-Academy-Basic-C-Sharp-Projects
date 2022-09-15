using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a list of of ints and strings 
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Joe", "Smith"));
            employees.Add(new Employee(2, "Dingo", "Smith"));
            employees.Add(new Employee(3, "Lenny", "Smith"));
            employees.Add(new Employee(4, "Jakey", "Smith"));
            employees.Add(new Employee(5, "Denna", "Smith"));
            employees.Add(new Employee(6, "Christ", "Smith"));
            employees.Add(new Employee(7, "Harry", "Smith"));
            employees.Add(new Employee(8, "Sara", "Smith"));
            employees.Add(new Employee(9, "Susan", "Smith"));
            employees.Add(new Employee(10, "Joe", "Scott"));

            //for each loop iterating through the list employees
            foreach (var I in employees)
            {
                //if statement comparing the value Joe through the list from the iteration of the foreach loop with _firstName.  If there is a mach, making a new list of just Joes.
                if (I._firstName == "Joe")
                {
                    //new list for just Joe employees
                    List<Employee> joe = new List<Employee>();
                    joe.Add(I);
                    //a foreach loop to pring to the console each value in the list
                    foreach (var j in joe)
                    {
                        //Console.WriteLine($"Id: {j._Id} Name: {j._firstName} {j._lastName}");
                    }

                    //a lambda expresion creating a new list for just the value joe from the if statment comparing all the _firstName values in the list to Joe.
                    new List<Employee>(joe).ForEach(i => Console.WriteLine($"Id: {i._Id} Name: {i._firstName} {i._lastName}"));
                }

            }
            Console.WriteLine("");
            //for each loop iterating through employees
            foreach (var j in employees)
            {
                //if statement comparing all the id numbers to greater then 5 through the iteration of the foreach loop.
                if (j._Id > 5)
                {
                    //creating a list of only id number eployees greater than 5.
                    List<Employee> idnumber5 = new List<Employee>();
                    idnumber5.Add(j);

                    //a lambda expresion printing to console the value id number greater than 5 from the if statment comparing all the _id values in the list to > 5.
                    new List<Employee>(idnumber5).ForEach(i => Console.WriteLine($"Id: {j._Id} Name: {j._firstName} {j._lastName}"));

                }
            }
            Console.ReadLine();
        }
    }
}