using StudentFinalChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db=new StudentContext())
            {
                Console.Write("Enter Student First Name: ");
                var firstName = Console.ReadLine();

                Console.Write("Enter Student Last Name: ");
                var lastName = Console.ReadLine();

                var student = new Student { FirstName = firstName.ToUpper(), LastName = lastName.ToUpper() };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.LastName
                            select s;

                Console.WriteLine("All Students in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName}");
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
