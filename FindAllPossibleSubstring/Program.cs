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


    }
}
