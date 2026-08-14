using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class student
    {
        private int enrollmentNo;
        private string name;
        private string course;

        public student(int eno, string nm, string crs)
        {
            enrollmentNo = eno;
            name = nm;
            course = crs;
        }

        public void Display()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Course :" + course);
        }
    }

    class Program8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Enrollment No. :");
            int eno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Course:");
            string course = Console.ReadLine();

            student s = new student(eno, name, course);

            s.Display();

            Console.WriteLine("Enrollment No. : 24SOECE11008");
            Console.WriteLine("Name : Aesh Domadiya");
            Console.ReadLine();
        }

    }
}