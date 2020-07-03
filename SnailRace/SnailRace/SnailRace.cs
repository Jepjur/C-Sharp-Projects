using System;

namespace SnailRace
{
    class SnailRace
    {
        static void Main(string[] args)
        {
            int tracklength = 330;
            int s1Position = 0;
            int s2Postition = 0;

            Snail s1 = new Snail(10, 20, "James");
            Snail s2 = new Snail(12, 18, "Jim");

            Console.WriteLine("Welcome to Snail Race! Now it's off to the races!");

            //Loop until a snail has finished
            while (s1Position < tracklength && s2Postition < tracklength)
            {
                int move1 = s1.Move();
                s1Position += move1;
                int move2 = s2.Move();
                s2Postition += move2;
                Console.WriteLine(s1.ToString() + " moves " + move1 + " for a total of " + s1Position);
                Console.WriteLine(s2.ToString() + " moves " + move2 + " for a total of " + s2Postition);
            }

            //Calculate winner
            if (s1Position >= 330 && s2Postition >= 330)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (s1Position >= 330)
            {
                Console.WriteLine(s1.ToString() + " wins the race!");
            }
            else if (s2Postition >= 330)
            {
                Console.WriteLine(s2.ToString() + " wins the race!");
            }
            else
            {
                Console.WriteLine("Uh oh, something went wrong");
            }

            Console.WriteLine("Press any key to exit.");
            ConsoleKey repeatAnswer = Console.ReadKey().Key;
        }
    }
}
