using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class P1
    {
        private int age;
        private string name;

        // Parameterized Constructor
        public P1(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine("Age of Person : " + age);
            Console.WriteLine("Name of Person : " + name);
        }
    }

    internal class Program20
    {
        public static void Main(string[] args)
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008\"");
            Console.WriteLine("-----------------------------------\n");

            P1 p1 = new P1(20, "Aesh");
            p1.Display();

            Console.ReadLine(); // Kept terminal open after execution
        }
    }

}
