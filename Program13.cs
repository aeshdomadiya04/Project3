using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class ProductDetails
    {
        public int prodid { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public double CalculateBill()
        {
            return price * quantity;
        }

        public void Display()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Product ID: " + prodid);
            Console.WriteLine("Product Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Bill Amount: " + CalculateBill());
        }
    }
    class Program13
    {
        static void Main(string[] args)
        {
            ProductDetails p = new ProductDetails();

            //Access product details
            Console.WriteLine("Enter Product ID:");
            p.prodid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name:");
            p.name = Console.ReadLine();

            Console.WriteLine("Enter Price:");
            p.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Quantity:");
            p.quantity = Convert.ToInt32(Console.ReadLine());

            p.Display();
            p.CalculateBill();
            Console.ReadLine();
        }
    }
}
