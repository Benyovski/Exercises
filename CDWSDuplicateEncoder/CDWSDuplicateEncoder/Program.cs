using System.Text;

namespace CDWSDuplicateEncoder
{
    internal class Program
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            StringBuilder result = new();
            foreach (char c in word)
            {
                if (word.Count(x => x == c) > 1)
                {
                    result.Append(")");
                }
                else
                {
                    result.Append("(");
                }
            }
            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
