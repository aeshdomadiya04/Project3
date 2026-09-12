using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    internal class Program25
    {
        static void Main(string[] args)
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008");
            Console.WriteLine("-----------------------------------\n");

            // Fixed spelling from "Entre" to "Enter"
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            password = password.Trim();

            Console.WriteLine("\nPassword Details");
            Console.WriteLine("----------------");

            Console.WriteLine("Password Length : " + password.Length);

            if (password.Length < 8)
            {
                // Fixed spelling "leas" to "least"
                Console.WriteLine("Password must contain at least 8 characters.");
            }
            else
            {
                Console.WriteLine("Password Length is Valid");

                if (password.Contains("@") || password.Contains("#") || password.Contains("$"))
                {
                    // Fixed spelling "Avialable" to "Available"
                    Console.WriteLine("Special Character : Available");
                }
                else
                {
                    Console.WriteLine("Special Character : Not Available");
                }

                Console.WriteLine("Uppercase Password : " + password.ToUpper());
                Console.WriteLine("Lowercase Password : " + password.ToLower()); // Fixed casing "LowerCase" to "Lowercase"

                string modifiedPassword = password.Replace("@", "#");
                Console.WriteLine("Modified Password  : " + modifiedPassword);
            }

            Console.ReadLine(); // Kept terminal open after execution
        }

    }
}
