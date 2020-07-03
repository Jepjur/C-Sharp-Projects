using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace StringConverter
{
    public class StringConverter
    {
        // Constructor
        public StringConverter()
        {

        }

        // Methods
        // Reverses a string
        public string ReverseString(string str)
        {
            string newString = string.Empty;
            char[] strArray = str.ToCharArray();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newString += strArray[i];
            }
            return newString;
        }

        // Checks if a string is a palindrome

        public bool IsPalindrome(string str)
        {
            string tempString = string.Empty;
            char[] strArray = str.ToCharArray();

            // Remove special characters from the string
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9') || (str[i] >= 'A' && str[i] <= 'z')) {
                    tempString += strArray[i];
                }
            }

            // Convert the string to lowercase
            tempString = tempString.ToLower();
            string reversedString = ReverseString(tempString);

            // Check if the reversed string is equal to the original
            if (reversedString.Equals(tempString))
            {
                Console.WriteLine("True");
                return true;
                
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }


        // Converts words to piglatinate
        public string PigLatinate(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            str = str.ToLower();
            foreach (string word in str.Split(' '))
            {
                // If word starts with a vowel add "yay"
                if (word.IndexOf("e") == 0 || word.IndexOf("a") == 0 || word.IndexOf("o") == 0 || word.IndexOf("u") == 0 || word.IndexOf("i") == 0)
                {
                    char punctuation = word.ElementAt(word.Length - 1);
                    if (punctuation.Equals('!') || punctuation.Equals('.') || punctuation.Equals('?'))
                    {
                        str = str.Replace(word, word.Remove(word.Length -1) + "yay" + punctuation);
                    }
                    else
                    {
                        str = str.Replace(word, word + "yay");
                    }
                }

                // If word contains vowels but doesn't start with one then:
                // Start at the first vowel instead
                // Take everything that came before the first vowel and add it at the end
                // Then add "ay" and any punctuation if applicable

                else if (word.Contains('a') || word.Contains('e') || word.Contains('o') || word.Contains('u') || word.Contains('i'))
                {
                        int index = word.IndexOfAny(vowels);
                        string end = word.Substring(0, index);
                        string start = word.Substring(index);
                        start = start.Remove(start.Length - 1);
                        char punctuation = word.ElementAt(word.Length - 1);
                    if (punctuation.Equals('!') || punctuation.Equals('.') || punctuation.Equals('?'))
                    {
                        str = str.Replace(word, start + end + "ay" + punctuation);
                    }
                    else
                    {
                        str = str.Replace(word, start + end + "ay");
                    }
                }
                // If word doesn't contain any vowels add "ay"
                else
                {
                    char punctuation = word.ElementAt(word.Length - 1);
                    if (punctuation.Equals('!') || punctuation.Equals('.') || punctuation.Equals('?'))
                    {
                        str = str.Replace(word, word + "ay" + punctuation);
                    }
                    else
                    {
                        str = str.Replace(word, word + "ay");
                    }
                    
                }
            }
            Console.WriteLine(str);
            return str;

        }

        // Converts a sentence into a shorter sentence according to certain rules
        public string Shorthand(string str)
        {
            string vowels = "aeiou";
            str.ToLower();
            // Replace certain words with shorter versions
            str = str.Replace("to", "2");
            str = str.Replace("you", "U");
            str = str.Replace("for", "4");
            str = str.Replace("be", "B");
            str = str.Replace("are", "R");

            // Loop through each word
            foreach (string word in str.Split(' '))
            {
                // Do nothing If it's an I, A, a, U 
                if (word == "a" || word == "A" || word == "U" || word == "I")
                {
                    continue;
                }
                // Removes vowels from each word
                else
                {
                    foreach (char c in vowels)
                    {
                        if (str.Contains(c))
                        {
                            str = str.Replace(c.ToString(), "");
                        }
                    }
                }
            }
            Console.WriteLine(str);
            return str;
        }


    }
}
