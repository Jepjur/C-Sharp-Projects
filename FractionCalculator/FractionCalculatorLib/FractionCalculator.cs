using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculatorLib
{
    class FractionCalculator
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Fraction Calculator!");
            Console.WriteLine("It will add, subtract, multiply, and divide fractions until you type Q to quit.");
            Console.WriteLine("Please enter your fractions in the form a/b where a and b are both integers.");
        }
        public string getOperation()
        {
            bool userInput = true;
            do
            {
                    Console.WriteLine("Please enter an operation (+, -, *, /, = or Q to quit");
                    string keyPress = Console.ReadLine();

                    if (keyPress.ToLower() == "q")
                    {
                        Console.WriteLine("The program will now exit, press any key to quit");
                        Console.ReadKey();
                        userInput = false;
                    }
                    else if (keyPress == "+" || keyPress == "-" || keyPress == "*" || keyPress == "/")
                    {
                        userInput = false;
                    }
                return keyPress;
            }
            while (userInput == true);

        }

        public bool validFraction(string input)
        {
            if (input.IndexOf("-") != 0)
            return true;
        }

        public Fraction getFraction()
        {
            bool userInput = true;
            do
            {
                Console.WriteLine("Please enter a fraction (a/b) or integer (a)");
                string keyPress = Console.ReadLine();

                if (keyPress.ToLower() == "q")
                {
                    Console.WriteLine("The program will now exit, press any key to quit");
                    Console.ReadKey();
                    userInput = false;
                }
                else if (keyPress == "+" || keyPress == "-" || keyPress == "*" || keyPress == "/")
                {
                    userInput = false;
                }
                return keyPress;
            }
            while (userInput == true);
            return new Fraction(2, 3);
        }
    }
}
