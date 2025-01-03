using System.Numerics;

namespace LCStringToInteger
{
    public class Program
    {
        public int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            s = s.Trim();
            string? resultString = default;
            bool minusDetected = default;
            System.Numerics.BigInteger overloadCheck = default;
            for (int i = 0; i < s.Length; i++)
            {
                if (minusDetected || i > 0)
                {
                    if (!char.IsDigit(s[i]))
                    {
                        break;
                    }
                }
                if (s[i] == '-')
                {
                    minusDetected = true;
                }
                else if (s[i] == '+')
                {
                    continue;
                }
                else if (char.IsDigit(s[i]))
                {
                    resultString += s[i];
                }
                else
                {
                    break;
                }
            }
            if (string.IsNullOrEmpty(resultString))
            {
                return 0;
            }
            if (minusDetected)
            {
                resultString = "-" + resultString;
            }
            overloadCheck = BigInteger.Parse(resultString);
            if (overloadCheck > int.MaxValue)
            {
                return int.MaxValue;
            }
            else if (overloadCheck < int.MinValue)
            {
                return int.MinValue;
            }
            return int.Parse(resultString);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
