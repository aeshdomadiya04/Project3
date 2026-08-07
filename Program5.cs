using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class Product
    {
        int pcode;
        String pname, mname;

        public Product(int pcd, String pnm, String mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        public void Display()
        {
            Console.WriteLine("Product Code:= " + pcode);
            Console.WriteLine("Product Name:= " + pname);
            Console.WriteLine("Manufacturer Name:= " + mname);
        }
    }

    public class Program5 
    {
        public static void Main(string[] args)
        {
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error");
                return;
            }

            int pcd = Convert.ToInt32(args[0]);
            String pnm = args[1];
            String mnm = args[2];

            Product p = new Product(pcd, pnm, mnm);
            p.Display();

            Console.WriteLine("Name : Aesh Domadiya");
            Console.WriteLine("Enrollment no. : 24SOECE11008");
            Console.Read();

        }
    }
}
