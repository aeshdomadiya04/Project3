using System;

class Employee
{
    // Private data member
    private double salary;

    // Public method to set salary
    public void SetSalary(double salary)
    {
        if (salary >= 0)
        {
            this.salary = salary;
        }
        else
        {
            Console.WriteLine("Salary cannot be negative.");
        }
    }

    // Public method to get salary
    public double GetSalary()
    {
        return salary;
    }
}

class Program14
{
    static void Main()
    {
        // Personal Header Details
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment: 24SOECE11008");
        Console.WriteLine("-----------------------------------\n");

        Employee emp = new Employee();

        // Setting salary using public method
        emp.SetSalary(50000);

        // Accessing salary using public method
        Console.WriteLine("Employee Salary: Rs. " + emp.GetSalary());

        Console.ReadLine();
    }
}
