using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class student3
    {
        public int Id;
        public string name;

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
        public student3()
        {
            Id = 1;
            name = "Aesh";

        }
        //Parameterized constructor
        public student3(int i, string n)
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

    class Program3
    {
        static void Main(string[] args)
        {
            student3 s = new student3(108, "Aesh");
            s.Display();
        }
    }
}
