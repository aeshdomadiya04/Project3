using System;
using System.Collections.Generic;
using System.Text;

namespace Project3
{
    class BankAccount
    {
        private int accountNo;
        private string accountHolder;
        private double balance;

        //constructor
        public BankAccount(int accNo, string holder, double amount)
        {
            accountNo = accNo;
            accountHolder = holder;
            balance = amount;
        }

        //Deposit method
        public void Deposit(double amount)
        {
            balance += amount;    //balance = balance + amount
            Console.WriteLine("Amount Deposited Successfully.");
        }

        //Withdraw method
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;    //balance = balance - amount
                Console.WriteLine("Amount Withdrawn Successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }

        //Balance Enquiry method
        public void BalanceEnquiry()
        {
            Console.WriteLine("\nAccount No: " + accountNo);
            Console.WriteLine("Account Holder: " + accountHolder);
            Console.WriteLine("Balance: " + balance);
        }
    }
    class Program11
    {
        static void Main()
        {
            // Create Two Bank Accounts
            BankAccount acc1 = new BankAccount(1001, "Rahul", 10000);
            BankAccount acc2 = new BankAccount(1002, "Priya", 15000);

            Console.WriteLine("Account 1 Transactions:");
            acc1.Deposit(2000);
            acc1.Withdraw(3000);
            acc1.BalanceEnquiry();

            Console.WriteLine("---------------------------------");

            Console.WriteLine("Account 2 Transactions:");
            acc2.Deposit(5000);
            acc2.Withdraw(2000);
            acc2.BalanceEnquiry();

            Console.ReadLine();
        }
    }
}
