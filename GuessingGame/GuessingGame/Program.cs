﻿using System;

namespace GuessingGame
{
    /// Generate a number between 1 and 100 and ask the user to guess it
    class Program
    {
        static void Main(string[] args)
        {
            // Generates the number

            Random rand = new Random();
            int answer = rand.Next(100) + 1;
            Init();
            Play(answer);
        }

        private static void Init()
        {
            Console.WriteLine("Greetings! Can you guess the number between 1 and 100? Enter the number to see if you are correct!");
        }

        // Determine if user guessed correctly, and gives a hint
        private static void Play(int answer)
        {
            bool won = false;
            do {
                Console.WriteLine("Please enter a new number!");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (answer == guess)
                {
                    Console.WriteLine("Your guess is correct, congratulations!");
                    won = true;
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else
                {
                    Console.WriteLine("Your guess is too low!");
                }
            }
            while (won == false);
           
        }

    }
}
