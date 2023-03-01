using System;

namespace FindAllPossibleSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "abcd";
            PrintAllSubstrings(input);
        }

        public static void PrintAllSubstrings(string str)
        {
            // Loop through each character in the string    
            for (int i = 0; i < str.Length; i++)
            {
                // Generate all substrings starting from this character
                for (int j = i + 1; j <= str.Length; j++)
                {
                    Console.WriteLine(str.Substring(i, j - i));
                }
            }
        }

        //In the outer loop, we start with the first character of the input string and 
        //  iterate up to the last character.In the inner loop, we start with the 
        //  current character of the outer loop and iterate up to the last character of 
        //  the input string. For each combination of i and j, we use the Substring() method 
        //  to extract the substring from the input string and print it to the console.
    }
}
