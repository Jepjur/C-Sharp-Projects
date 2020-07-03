﻿using System;

namespace Mini_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Greet the user

            Console.WriteLine("Let's play a game called \"Odds or Evens!\"");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            // Let the user pick odds or evens
            Console.WriteLine($"Hi " + (userName) + ", which do you choose? (O)dds or (E)vens?");
            string input = Console.ReadLine();
            string choice = input.ToUpper();

            if (choice.Equals("O"))
            {
                Console.WriteLine(userName + " has picked odds! The computer will be evens");
            }
            else
            {
                Console.WriteLine(userName + " has picked evens! The computer will be odds");
            }

            Console.WriteLine("----------------------------------------------");

            // Play the game

            // Get fingers from user and computer

            int userFinger;
            do
            {
                Console.WriteLine("How many \"fingers\" do you throw? Choose a number from 1 to 5");
                userFinger = Convert.ToInt32(Console.ReadLine());
            }
            while (userFinger > 5 || userFinger < 1);

            Random rand = new Random();
            int computerFinger = rand.Next(1, 5);
            Console.WriteLine("The computer plays " + (computerFinger) + " \"fingers\"");
            Console.WriteLine("----------------------------------------------");

            // Calculate the outcome

            int sum = userFinger + computerFinger;
            if (sum % 2 == 0)
            {
                Console.WriteLine(userFinger + " + " + computerFinger + " = " + sum);
                Console.WriteLine(sum + " is even!");

                if (userFinger % 2 == 0)
                {
                    Console.WriteLine(userName + " wins!");
                }
                else
                {
                    Console.WriteLine("The computer wins!");
                }
            }
            else
            {
                Console.WriteLine(userFinger + " + " + computerFinger + " = " + sum);
                Console.WriteLine(sum + " is odd!");

                if (userFinger % 2 == 1)
                {
                    Console.WriteLine(userName + " wins!");
                }
                else
                {
                    Console.WriteLine("The computer wins!");
                }
            }
        }
    }
}
