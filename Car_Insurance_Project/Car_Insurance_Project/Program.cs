using System;

namespace Car_Insurance_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the basic approval program. Find out if you qaulify for car insurance.");

            //Drivers Age
            Console.WriteLine("What is your age?");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt16(ageStr);

            //Drivers DUI record
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            string duiStr = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiStr);

            //Drivers Speeding record
            Console.WriteLine("How many speeding tickets do you have?");
            string speedStr = Console.ReadLine();
            int speed = Convert.ToInt16(speedStr);

            //Is driver qualified for insurance
            bool qualified = (age > 15 && dui == false && speed <= 3);
            Console.WriteLine("Please see below if you qualify for car insurance:");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
