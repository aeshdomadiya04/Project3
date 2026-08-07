using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    internal class student
    {
        private int enroll;
        private string name;
        private string branch;

        public void AcceptData(int e, string n, string b)
        {
            enroll = e;
            name = n;
            branch = b;
        }
        public void Display()
        {
            Console.WriteLine("---------student detatils------------");
            Console.WriteLine("Enrollment number is:" + enroll);
            Console.WriteLine("name is:" + name);
            Console.WriteLine("branch is:" + branch);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            student std1 = new student();
            student std2 = new student();

            std1.AcceptData(101, "meet", "IT");
            Console.WriteLine("Student 1 details");
            std1.Display();

            std2.AcceptData(102, "harsh", "CE");
            Console.WriteLine("Student 2 deatails");
            std2.Display();

            Console.ReadLine();
        }
    }
}
