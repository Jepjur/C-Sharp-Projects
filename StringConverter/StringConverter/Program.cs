using System;

namespace StringConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Checking to see if everything works
            StringConverter string1 = new StringConverter();
            Console.WriteLine(string1.ReverseString("Hello World"));
            string1.IsPalindrome("Hello");
            string1.PigLatinate("You need our new atomic refrigerator!");
            string1.Shorthand("You are not as funny as you think you are");
        }

    }
}
