using System;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to perform basic math operations on.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int newNumAdd = Methods.addInt(userNum);
            int newNumSub = Methods.subInt(userNum);
            int newNumMult = Methods.multInt(userNum);

            Console.WriteLine("Your number plus 55 is: " + newNumAdd);
            Console.WriteLine("Your number subtracted by 55 is: " + newNumSub);
            Console.WriteLine("Your number multiplied by 55 is: " + newNumMult);
            Console.ReadLine();
        }
    }
    }
