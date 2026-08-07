using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class Line
    {
        private double length;   // Length of a line

        public Line()

        {
            Console.WriteLine("Object creating value = 10");
            length = 10;
        }



        public void setLength(double len)

        {
            length = len;
        }

        public double getLength()

        {
            return length;
        }
    }



    class Program6

    {

        static void Main(string[] args)

        {

            Line line = new Line();

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            line.setLength(6);

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();

        }
    }
}
