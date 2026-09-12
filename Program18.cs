using System;
using System.Xml.Linq;

namespace Project3
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public virtual void GenerateSalarySlip()
        {
            Console.WriteLine("Employee Salary Slip");
        }
    }

    class PermanentEmployeeSlip : Employee
    {
        public override void GenerateSalarySlip()
        {
            double hra = Salary * 20 / 100;
            double da = Salary * 10 / 100;
            double netSalary = Salary + hra + da;

            Console.WriteLine("Permanent Employee Salary Slip");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Name       : " + Name);
            Console.WriteLine("Basic Salary: " + Salary);
            Console.WriteLine("HRA        : " + hra);
            Console.WriteLine("DA         : " + da);
            Console.WriteLine("Net Salary : " + netSalary);
        }
    }

    // Renamed to avoid duplicate type in namespace
    class ContractEmployeeSlip : Employee
    {
        public override void GenerateSalarySlip()
        {
            Console.WriteLine("Contract Employee Salary Slip");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Name        : " + Name);
            Console.WriteLine("Salary      : " + Salary);
            Console.WriteLine("Net Salary  : " + Salary);
        }
    }

    class Program18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-------------------------------");

            PermanentEmployeeSlip employee1 = new PermanentEmployeeSlip();

            employee1.Name = "Aesh";
            employee1.Salary = 30000;

            employee1.GenerateSalarySlip();

            Console.WriteLine();

            ContractEmployeeSlip employee2 = new ContractEmployeeSlip();

            employee2.Name = "Resh";
            employee2.Salary = 25000;

            employee2.GenerateSalarySlip();

            Console.ReadLine();
        }
    }
}