using System;
using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    public class StringWorks
    {
        Error error = new Error();

        // Implement a palindrome checker to make the following test cases pass. 
        //This starter code is in C# but you are welcome to write your solution in any language
        public bool IsPalindrome(string s)
        {
            try
            {
                s = string.IsNullOrEmpty(s) ? "" : s.ToLower();
                Regex rgx = new Regex(@"[\s\W]+");
                s = rgx.Replace(s, "");

                var reverseString = Reverse(s);

                return s == reverseString;

            }
            catch(Exception ex)
            {
                error.DisplayError(Error.EnumErrors.GenericErrorLog, ex.Message);
                return false;
            }
        }

        public string Reverse(string s)
        {
            char[] charArray = string.IsNullOrEmpty(s) ? "".ToCharArray() : s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            return true;
        }


        public void Check(string s, bool shouldBePalindrome)
        {
            if (IsValid(s))
            {
                Console.WriteLine(IsPalindrome(s) == shouldBePalindrome ? "pass" : "FAIL");
            }
            else
            {
                error.DisplayError(Error.EnumErrors.NotValid);
            }
        }
    }
}
