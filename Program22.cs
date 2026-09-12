using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    // Capitalised class name to follow C# standards
    class E2
    {
        public void EmpStatus()
        {
            Console.WriteLine("Employee is Working"); // Fixed spelling "Wroking"
        }
    }

    class D2 : E2
    {
        // Using the 'new' keyword to explicitly hide the base class method
        public new void EmpStatus()
        {
            Console.WriteLine("Employee is Not Working");
        }
    }

    internal class Program22
    {
        public static void Main(string[] args)
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            D2 d = new D2();
            d.EmpStatus();

            Console.ReadLine(); // Kept terminal open after execution
        }
    }

}
