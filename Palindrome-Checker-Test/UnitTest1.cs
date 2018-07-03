using PalindromeChecker;
using Xunit;

namespace Palindrome_Checker_Test
{
    public class UnitTest1
    {
        StringWorks sw = new StringWorks();
        string validPal = "12344321";
        string notValidPal = "someone stole my lunch";
        string nullString = null;
        string emptyString = "";

        //Palindrome
        [Fact]
        public void CheckPalindromeValidString_True()
        {
            Assert.Equal(true, sw.IsPalindrome(validPal));
        }

        [Fact]
        public void CheckPalindromeValidString_False()
        {
            Assert.Equal(false, sw.IsPalindrome(notValidPal));
        }
       
        [Fact]
        public void CheckPalindromeNullString_True()
        {
            Assert.Equal(true, sw.IsPalindrome(nullString));
        }

        [Fact]
        public void CheckPalindromeEmptyString_True()
        {
            Assert.Equal(true, sw.IsPalindrome(emptyString));
        }

        //Reverse
        [Fact]
        public void Reverse_True()
        {
            Assert.Equal("123asc789", sw.Reverse("987csa321"));
        }

        [Fact]
        public void Reverse_Null()
        {
            Assert.Equal("".ToCharArray(), sw.Reverse(null));
        }

        //IsValid

        [Fact]
        public void IsValid_True()
        {
            Assert.Equal(true, sw.IsValid(validPal));
        }

        [Fact]
        public void IsValid_False()
        {
            Assert.Equal(false, sw.IsValid(emptyString));
        }

        [Fact]
        public void IsValid_Null()
        {
            Assert.Equal(true, sw.IsPalindrome(nullString));
        }
    }
}
