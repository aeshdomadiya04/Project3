using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class Student3
    {
        public int Id;
        public string name;


        //property
        public int id
        {
            get { return id; }    //GET will read value
            set { id = value; }   //SET will write value
        }


        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }

        //Empty//default constructor
        public Student3()
        {
            Id = 1;
            name = "Aesh";

        }
        //Parameterized constructor
        public Student3(int i, string n)
        {
            Id = i;
            name = n;
        }


        //Static method
        public void Display()
        {
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Name:" + name);

        }

    }

    class Program4
    {
        static void Main(string[] args)
        {
            Student3 s1 = new Student3(101, "Aesh");
            Student3 s2 = new Student3(102, "Dhara");
            Student3 s3 = new Student3(103, "Ritesh");
            Student3 s4 = new Student3(104, "Brinda");
            Student3 s5 = new Student3(105, "Helli");

            s1.Display();
            s2.Display();
            s3.Display();
            s4.Display();
            s5.Display();

        }
    }
}
