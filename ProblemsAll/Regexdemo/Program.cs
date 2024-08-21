using System.Text.RegularExpressions;

namespace Day11
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string pattern1 = "a*b";//preceding character zero or more
            string pattern2 = "a+b";//preceding character oner or more
            Regex rex = new Regex(pattern2);
            string x = "1234";
            Match match = rex.Match("abcdef");
            if (match.Success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}