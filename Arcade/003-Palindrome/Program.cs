using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkPalindrome(args[0]));
        }

        /* Given the string, check if it is a palindrome. */
        static bool checkPalindrome(string inputString) {
            bool isPalindrome = true;
            for (int i = 0; i < inputString.Length; i++) {
                if (inputString[i] != inputString[(int)inputString.Length - i - 1]) {
                isPalindrome = false;
                return false;
                }
            }
            return isPalindrome;
        }
    }
}
