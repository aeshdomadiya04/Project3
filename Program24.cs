using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    internal class Program24
    {
        // Sealed class cannot be inherited by other classes
        sealed class University
        {
            private string school_name;
            private string department_name;

            public University(string school_name, string department_name)
            {
                this.school_name = school_name;
                this.department_name = department_name;
            }

            public void Display()
            {
                Console.WriteLine("School Name: " + school_name);
                Console.WriteLine("Department Name: " + department_name);
            }
        }

        public static void Main(string[] args)
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            University U = new University("RKU", "CE");
            U.Display();

            Console.ReadLine();
        }

    }
}
