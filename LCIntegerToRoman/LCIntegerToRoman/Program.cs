namespace LCIntegerToRoman
{
    public class Program
    {
        /// <summary>
        /// Given an integer, convert it to a roman numeral. Input is guaranteed to be within the range from 1 to 3999. 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string IntToRoman(int num)
        {
            if (num < 1 || num > 3999)
            {
                return string.Empty;
            }
            int[] values = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];
            string[] symbols = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];
            System.Text.StringBuilder romanNumber = new();
            for (int i = 0; i < values.Length && num > 0; i++)
            {
                if (num >= values[i])
                {
                    romanNumber.Append(symbols[i]);
                    num -= values[i];
                    i--;
                }
                else
                {
                    continue;
                }
            }
            return romanNumber.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
