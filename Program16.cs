using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class Employee1
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }
    }

    // Fixed spelling from "PermanentEmloyee" to "PermanentEmployee"
    class PermanentEmployee : Employee1
    {
        public void CalculateSalary()
        {
            double hra = BasicSalary * 0.20;
            double da = BasicSalary * 0.10;
            double netSalary = BasicSalary + hra + da;

            Console.WriteLine("\nPermanent Employee");
            Console.WriteLine("--------------------");
            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Name        : " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary); // Fixed spelling "Slary"
            Console.WriteLine("HRA         : " + hra);
            Console.WriteLine("DA          : " + da);
            Console.WriteLine("Net Salary  : " + netSalary);
        }
    }

    class ContractEmployee : Employee1
    {
        public void CalculateSalary()
        {
            double netSalary = BasicSalary;

            Console.WriteLine("\nContract Employee");
            Console.WriteLine("-----------------");
            Console.WriteLine("Employee Id : " + EmpId);
            Console.WriteLine("Name        : " + Name);
            Console.WriteLine("Salary      : " + netSalary);
        }
    }

    internal class Program16
    {
        public static void Main(string[] args)
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            // Fixed class instantiation name spelling
            PermanentEmployee p = new PermanentEmployee();
            p.EmpId = 10;
            p.Name = "Aesh";
            p.BasicSalary = 100000;

            p.CalculateSalary();

            ContractEmployee c = new ContractEmployee();
            c.EmpId = 12;
            c.Name = "Ritesh";
            c.BasicSalary = 23900;

            c.CalculateSalary();

            Console.ReadLine(); // Kept terminal open after execution
        }
    }
}
