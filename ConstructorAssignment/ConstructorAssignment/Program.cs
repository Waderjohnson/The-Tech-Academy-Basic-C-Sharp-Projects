using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConstructorAssignment
{
    public class Program
    {
        public class Animal
        {
            const string kingdom = "Animalia";
            public string Phylum { get; set; }
            public int Age { get; set; }
            public string Species { get; set; }

            public Animal(string phylum, int age, string species)
            {
                Age = age;
                Phylum = phylum;
                Species = species;
            }

            public Animal(string phylum) : this(phylum, 500, " S. microcephalus ")
            {

            }

            public Animal(int age) : this("Shark ", age, "	S. microcephalus ")
            {

            }
        }


        static void Main(string[] args)
        {
            var shark = new Animal("Greenland Shark");
            Console.WriteLine(shark.Phylum + " " + shark.Age + " " + shark.Species);
            Console.ReadLine();

        }
    }
}