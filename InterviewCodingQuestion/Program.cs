using System;
using System.Collections.Generic;

namespace InterviewCodingQuestion
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "tmafeshermarch";
            string output = RemoveDuplicateCharacters(input);
            Console.WriteLine(output);
           
        }

        public static string RemoveDuplicateCharacters(string str)
        {
            // Create a new list to store unique characters
            List<char> uniqueChars = new List<char>();

            // Loop through each character in the string
            foreach (char c in str)
            {
                // If the character is not already in the list, add it
                if (!uniqueChars.Contains(c))
                {
                    uniqueChars.Add(c);
                }
            }

            // Convert the list to a string and return it
            return new string(uniqueChars.ToArray());
           
            //This line converts the uniqueChars list to a character array using the ToArray method,
            // and then creates a new string from the character array using the string constructor that
            // takes a character array as input.Finally, the resulting string with duplicates removed
            // is returned from the method.
        }
    }
}

