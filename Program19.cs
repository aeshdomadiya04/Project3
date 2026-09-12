using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class S1
    {
        static int count = 0;

        public S1()
        {
            count++;
        }

        public void Display()
        {
            Console.WriteLine("Total Number of Students: " + count);
        }
    }

    internal class Program19
    {
        public static void Main(string[] args)
        {
            // Personal Header Details
            Console.WriteLine("Name:Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            S1 s1 = new S1();
            S1 s2 = new S1();
            S1 s3 = new S1();
            S1 s4 = new S1();
            S1 s5 = new S1();

            s1.Display();

            Console.ReadLine();
        }
    }

}
