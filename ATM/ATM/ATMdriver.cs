using System;

namespace ATM
{
    class ATMdriver
    {
        static void Main(string[] args)
        {
            //Create a savingsaccount and checkingaccount

            SavingsAccount savings = new SavingsAccount(50, 5);
            CheckingAccount checking = new CheckingAccount(100);

            string depositInput;
            string withdrawInput;
            string transferInput;

            //Greet the user and ask what he wants to do

            Console.WriteLine("Hello! What would you like to do?");
            Console.WriteLine("(D)eposit, (W)ithdraw, (C)heck balance, (T)ransfer, (Q)uit");
            string input = Console.ReadLine().ToUpper();
           

              do {
                    if (input != "D" && input != "W" && input != "C" && input != "T" && input != "Q")
                    {
                        Console.WriteLine("Please enter a valid input. D, W, C, T or Q");
                        Console.WriteLine("(D)eposit, (W)ithdraw, (C)heck balance, (T)ransfer, (Q)uit");
                        input = Console.ReadLine().ToUpper();
                    }
                     else
                    {
                        continue;
                    }   
                } while (input != "D" && input != "W" && input != "C" && input != "T" && input != "Q");

            //Logic for deposits
            if (input == "D")
            {
                do
                {
                    Console.WriteLine("Deposit to (1)Checking or (2)Savings?");
                    depositInput = Console.ReadLine();
                    if (depositInput == "1")
                    {
                        Console.WriteLine("How much do you want to deposit?");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        checking.Deposit(depositAmount);
                        Console.WriteLine(depositAmount + " has been deposited to your checking account");

                        savings.PrintBalance();
                        checking.PrintBalance();
                    }
                    else if (depositInput == "2")
                    {
                        Console.WriteLine("How much do you want to deposit?");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        savings.Deposit(depositAmount);
                        Console.WriteLine(depositAmount + " has been deposited to your savings account");

                        savings.PrintBalance();
                        checking.PrintBalance();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a 1 or 2");
                    }
                } while (depositInput != "1" && depositInput != "2");
            }

            //Logic for withdrawing
            else if (input == "W")
            {
                do
                {
                    Console.WriteLine("Withdraw from (1)Checking or (2)Savings?");
                    withdrawInput = Console.ReadLine();
                    if (withdrawInput == "1")
                    {
                        Console.WriteLine("How much do you want to withdraw?");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        checking.Withdraw(withdrawAmount);
                        Console.WriteLine(withdrawAmount + " has been withdrawn from your checking account");

                        savings.PrintBalance();
                        checking.PrintBalance();
                    }
                    else if (withdrawInput == "2")
                    {
                        Console.WriteLine("How much do you want to withdraw?");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        savings.Deposit(withdrawAmount);
                        Console.WriteLine(withdrawAmount + " has been withdrawn from your savings account");

                        savings.PrintBalance();
                        checking.PrintBalance();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a 1 or 2");
                    }
                } while (withdrawInput != "1" && withdrawInput != "2");
            }

            //Logic for checking the balance
            else if (input == "C")
            {
                savings.PrintBalance();
                checking.PrintBalance();
            }

            //Logic for transferring money from one account to another
            else if (input == "T")
            {
                do
                {
                    Console.WriteLine("Transfer from (1)Checking to Savings(1) or from (2)Savings to Checking(2)?");
                    transferInput = Console.ReadLine();
                    if (transferInput == "1")
                    {
                        Console.WriteLine("How much do you want to transfer from your checking account to your saving saccount?");
                        decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
                        checking.Withdraw(transferAmount);
                        savings.Deposit(transferAmount);
                        Console.WriteLine(transferAmount + " has been transfered between your accounts");

                        savings.PrintBalance();
                        checking.PrintBalance();
                    }
                    else if (transferInput == "2")
                    {
                        Console.WriteLine("How much do you want to transfer from your savings account to your checking account?");
                        decimal transferAmount = Convert.ToDecimal(Console.ReadLine());
                        savings.Withdraw(transferAmount);
                        checking.Deposit(transferAmount);
                        Console.WriteLine(transferAmount + " has been transfered between your accounts");

                        savings.PrintBalance();
                        checking.PrintBalance();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please enter a 1 or 2");
                    }
                } while (transferInput != "1" && transferInput != "2");
            }

            //Exiting the program
            else if (input == "Q")
            {
                Console.WriteLine("The balance of your checking account is " + checking.Balance());
                Console.WriteLine("The balance of your savings account is " + savings.Balance());
                Console.WriteLine("Thank you for your business. Goodbye!");
                Console.WriteLine("Press any button to close this window");
                Console.ReadKey();
            }
        }
    }
}
