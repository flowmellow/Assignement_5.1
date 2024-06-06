/*
Given an integer x, return true if x is a palindrome, and false otherwise.
Example 1:
Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:
Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
*/

using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Assignement_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {          

            int input = -121;
            string inputConvert = Convert.ToString(input);

            if (CheckIfPalindrome(inputConvert))
            {
                Console.WriteLine("Yes it is a Palindrome");
            }
            else
            {
                Console.WriteLine("No it's not a Palindrome");
            }       

        }

        static bool CheckIfPalindrome(string inputConvert)
        {
            int length = inputConvert.Length;
            for (int i = 0; i < inputConvert.Length/2; i++)
            {
                if (inputConvert[i] != inputConvert[length - i - 1]) 
                {  
                    return false; 
                }
            }return true;

        }

       


    }
}
