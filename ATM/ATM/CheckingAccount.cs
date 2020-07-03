using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    class CheckingAccount
    {
        //Fields
        decimal balance;

        //Default Constructor
        public CheckingAccount()
        {
            new CheckingAccount(10);
        }

        //Custom Constructor
        public CheckingAccount(decimal balance)
        {
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

        public void PrintBalance()
        {
            Console.WriteLine("Your checking account has " + balance + " credits");
        }
    }
}
