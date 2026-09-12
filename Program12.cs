using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class StudentDetails
    {
        //get will read the value
        //set will write the value
        public int enroll_no { get; set; }
        public string name { get; set; }
    }

    class Program12
    {
        static void Main(string[] args)
        {
            StudentDetails studentDetails = new StudentDetails();

            Console.WriteLine("Enter Enrollment number:");
            studentDetails.enroll_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Name:");
            studentDetails.name = Console.ReadLine();

            Console.WriteLine("------------Student Details---------------");
            Console.WriteLine("Enrollment number is " + studentDetails.enroll_no);
            Console.WriteLine("Name is " + studentDetails.name);
            Console.ReadLine();
        }
    }
}
