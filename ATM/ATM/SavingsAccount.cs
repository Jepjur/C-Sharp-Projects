using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class SavingsAccount
    {
        //Fields
        decimal balance;
        decimal interestRate;


        //Constructor
        public SavingsAccount()
        {
            new SavingsAccount(10, 5);
        }
        public SavingsAccount(decimal balance, decimal interestRate)
        {
            this.interestRate = interestRate;
            this.balance = balance;
        }

        //Methods
        public void Withdraw(decimal withdraw)
        {
            balance -= withdraw;
        }

        public void Deposit(decimal deposit)
        {
            balance += deposit;
        }

        public decimal Balance()
        {
            return balance;
        }

        public void InterestRate(decimal interestRate)
        {
            balance *= ((interestRate + 100) / 100);
        }

        public void PrintBalance()
        {
            Console.WriteLine("Your savings account has " + balance + " credits");
        }
    }
}
