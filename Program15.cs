using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class Person
    {
        public int age { get; set; }
        public string gender { get; set; }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("\n-------Person's Details-------");
            Console.WriteLine("Age of person: " + age);
            Console.WriteLine("Gender of person: " + gender);
        }
    }

    // Renamed class "stud" to "Student" to follow standard naming conventions
    class Student : Person
    {
        public int enrol_no { get; set; }
        public string name { get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("----------Student's Details---------");
            Console.WriteLine("Enrollment number of student: " + enrol_no);
            Console.WriteLine("Name of student: " + name);
        }
    }

    internal class Program15
    {
        public static void Main(string[] args)
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            Student s = new Student();

            // Fixed spelling from "Entre" to "Enter"
            Console.WriteLine("Enter Person's Age: ");
            s.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Person's Gender: ");
            s.gender = Console.ReadLine();

            Console.WriteLine("Enter Student's Enrollment Number: ");
            s.enrol_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student's Name: ");
            s.name = Console.ReadLine();

            s.DisplayPersonDetails();
            s.DisplayStudentDetails();

            Console.ReadLine(); // Kept terminal open after execution
        }
    }
}
