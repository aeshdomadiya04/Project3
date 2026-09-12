using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    internal class Program21
    {
        class E1
        {
            protected string designation;
            protected double salary;

            public E1(string designation, double salary)
            {
                this.designation = designation;
                this.salary = salary;
            }
        }

        class D1 : E1
        {
            private string dept_name;

            public D1(string designation, double salary, string dept_name) : base(designation, salary)
            {
                this.dept_name = dept_name;
            }

            public void Display() // Changed to uppercase "Display" to match C# coding standards
            {
                Console.WriteLine("Designation of the Employee: " + designation); // Fixed spelling "Emplyee"
                Console.WriteLine("Salary of the Employee:      " + salary);
                Console.WriteLine("Department of the Employee:  " + dept_name); // Fixed string spacing for alignment
            }
        }

        public static void Main(string[] args)
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            // Fixed spelling "Embadded" to "Embedded" in data initialization
            D1 d = new D1("IT", 50000, "Embedded Systems");
            d.Display();

            Console.ReadLine(); // Kept terminal open after execution
        }
    }

}
