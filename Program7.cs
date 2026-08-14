using System;

namespace project1
{
    class studentDetails
    {
        private int enroll;
        private string name;

        public int e
        {
            get { return enroll; }
            set { enroll = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Empty constructor
        public studentDetails()
        {
        }

        // Parameterized constructor
        public studentDetails(int e, string n)
        {
            enroll = e;
            name = n;
        }

        public void Display()
        {
            Console.WriteLine("Enrollment number: " + enroll);
            Console.WriteLine("Name: " + name);
        }
    }

    class Program7
    {
        static void Main(string[] args)
        {
            studentDetails student = new studentDetails();

            Console.WriteLine("Enter enrollment number");
            student.e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            student.Name = Console.ReadLine();   // Corrected

            student.Display();
        }
    }
}