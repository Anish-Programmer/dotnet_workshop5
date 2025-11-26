using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

        // constructor
        public BankAccount(string accountNumber, double initialBalance) 
        { 
            this.accountNumber = accountNumber;

            // condtion
            if (initialBalance <= 0) 
            {
               
                throw new ArgumentException("Inital balance must be greater than 0.");
                //Console.WriteLine("Inital balance must be greater than 0.");
            }


            balance = initialBalance;
        }


        // read-only Account Number property
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // balance with private setter
        public double Balance
        { 
            get { return balance; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Balance cannot be zero or negative.");
                }

                balance = value;
            }
        }


        // Deposit method
        public void Deposit(double amount)
        {
            if (amount <= 0) 
            { 
                Console.WriteLine("Deposit amount must be greater than 0.");
                return;
            }

            Balance += amount; // using private setter
            Console.WriteLine($"Deposited: {amount}");
        }





        // withdraw method
        public void Withdraw(double amount)
        {
            if (amount <= 0) 
            {
                Console.WriteLine("Withdraw amount must be greater than zero.");
                return;
            }


            if (amount > Balance)
            { 
                Console.WriteLine("Insufficient balance!.");
                return;
            }

            Balance -= amount; // using private setter
            Console.WriteLine($"Withdrew: {amount}");
        }
    }
}
