1) How to remove duplicate characters from a string? 
Line 19: This line declares a new List<char> called uniqueChars to store unique characters from the input string.

Line 22: This block of code loops through each character c in the input string str. For each character, 
it checks if the uniqueChars list already contains the character using the Contains method. 
If the character is not already in the list, it adds it to the uniqueChars list using the Add method.

Line 32: This line converts the uniqueChars list to an array of characters using the ToArray method, 
and then creates a new string from the array using the string constructor. This new string contains all unique characters from the input string.




 2) How to find all possible substring of a given string
Line 13: 
This block of code begins by looping through each character in the input string str using a for loop. 
The variable i is used to keep track of the index of the current character in the loop.

For each character, the code then generates all possible substrings that start from that character. 
To generate these substrings, another for loop is used with a variable j that starts at i + 1 (to avoid generating substrings of length 1) 
and ends at str.Length. The Substring method is then used to extract the substring starting at index i and ending at index j-1 
(since the second argument of Substring is the length of the substring).

Finally, the generated substring is printed to the console using Console.WriteLine.

this method works by looping through each character in the input string and generating all possible substrings that start from that character. 
The generated substrings are printed to the console one by one. The output includes the input string itself as well as all substrings of length 1 
or greater.