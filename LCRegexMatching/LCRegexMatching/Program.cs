using System.Text.RegularExpressions;

namespace LCRegexMatching
{
    public class Program
    {
        /// <summary>
        /// A stub of a method that should be tested.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool IsMatchBeta(string s, string p)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p))
            {
                return false;
            }
            if(p.Length == 1)
            {
                return s.Length == 1 && (s[0] == p[0] || p[0] == '.');
            }
            return Regex.IsMatch(s, p);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
