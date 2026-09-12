using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class Program26
    {
        static void Main()
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nString Operations");
            Console.WriteLine("-------------------------");

            // Remove spaces from beginning and end             
            name = name.Trim();
            Console.WriteLine("After Trim       : " + name);

            // Convert name to uppercase 
            Console.WriteLine("Uppercase Name   : " + name.ToUpper());

            // Convert name to lowercase 
            Console.WriteLine("Lowercase Name   : " + name.ToLower());

            // Replace spaces with underscore             
            string replacedName = name.Replace(" ", "_");
            Console.WriteLine("After Replace    : " + replacedName);

            // Insert "Mr. " at the beginning             
            string formattedName = name.Insert(0, "Ms. ");
            Console.WriteLine("After Insert     : " + formattedName);

            // Display length 
            Console.WriteLine("Name Length      : " + name.Length);

            Console.ReadLine(); // Standardized to ReadLine to keep the window open cleanly
        }
    }
}
