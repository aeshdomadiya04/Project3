using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class EmployeeDetails
    {
        private int empid;
        private string empName;
        private double basicSalary;
        private double netSalary;

        public EmployeeDetails(int id, string name, double salary)
        {
            empid = id;
            empName = name;
            basicSalary = salary;
        }

        public void CalculateNetSalary()
        {
            double hra = basicSalary * 0.20; 
            double da = basicSalary * 0.10; 
            netSalary = basicSalary + hra + da;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("-----------Employee Details-----------");
            Console.WriteLine("Employee Id is " + empid);
            Console.WriteLine("Employee Name is " + empName);
            Console.WriteLine("Basic Salary is " + basicSalary);
            Console.WriteLine("Net Salary is " + netSalary);
        }
    }

    class Program10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Basic Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            EmployeeDetails emp = new EmployeeDetails(id, name, salary);
            emp.CalculateNetSalary();
            emp.DisplayEmployeeDetails();

            Console.ReadLine();
        }
    }

}
