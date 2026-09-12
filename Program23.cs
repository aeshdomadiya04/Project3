using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    // Abstract base class 
    // An abstract class cannot be used to create objects directly. 
    // It is designed to be a base/parent class for other classes. 
    abstract class Account
    {
        // Store account amount
        protected double amount;

        // Constructor to set amount
        public Account(double amount)
        {
            this.amount = amount;
        }

        // Abstract method
        public abstract void CalculateInterest();
    }

    // Saving Account class 
    class SavingAccount : Account
    {
        // Constructor
        public SavingAccount(double amount) : base(amount) { }

        // Calculate saving account interest
        public override void CalculateInterest()
        {
            Console.WriteLine("Saving Account Interest = " + (amount * 4 / 100));
        }
    }

    // Current Account class 
    class CurrentAccount : Account
    {
        // Constructor
        public CurrentAccount(double amount) : base(amount) { }

        // Calculate current account interest
        public override void CalculateInterest()
        {
            Console.WriteLine("Current Account Interest = " + (amount * 2 / 100));
        }
    }

    class Program23
    {
        public static void Main()
        {
            // Personal Header Details
            Console.WriteLine("Name: Aesh Domadiya");
            Console.WriteLine("Enrollment: 24SOECE11008\"");
            Console.WriteLine("-----------------------------------\n");

            // Create Saving Account object
            SavingAccount a = new SavingAccount(10000);

            // Calculate saving account interest
            a.CalculateInterest();

            // Create Current Account object
            CurrentAccount b = new CurrentAccount(10000);

            // Calculate current account interest
            b.CalculateInterest();

            Console.ReadLine(); // Standardized to ReadLine to keep the window open cleanly
        }

    }
}
