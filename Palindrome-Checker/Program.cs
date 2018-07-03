

namespace PalindromeChecker
{
    class Program
    {
        public static void Main()
        {
            StringWorks stringWorks = new StringWorks();

            stringWorks.Check("abcba", true);
            stringWorks.Check("abcde", false);
            stringWorks.Check("Mr owl ate my metal worm", true);
            stringWorks.Check("Never Odd Or Even", true);
            stringWorks.Check("Never Even Or Odd", false);
            stringWorks.Check("", true);
            stringWorks.Check(null, true);

        }
    }

}
