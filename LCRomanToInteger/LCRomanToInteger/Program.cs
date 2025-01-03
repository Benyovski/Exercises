namespace LCRomanToInteger
{
    public class Program
    {
        /// <summary>
        /// Given a roman numeral string, convert it to an integer.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int RomanToInt(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            int[] values = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
            string[] symbols = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (s.Substring(i).StartsWith(symbols[j]))
                    {
                        result += values[j];
                        i += symbols[j].Length - 1;
                        break;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
