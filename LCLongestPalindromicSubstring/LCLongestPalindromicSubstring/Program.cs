namespace LCLongestPalindromicSubstring
{
    public class Program
    {
        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            if (s.Length == 1)
            {
                return s;
            }
            if (s.Length == 2)
            {
                return (s[0] == s[1]) ? s : s[0].ToString();
            }
            short lowestBound = 0;
            short highestBound = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    short middleOfPalindrome = (short)j;
                    for (int k = 1; k <= middleOfPalindrome && middleOfPalindrome - k >= 0 && middleOfPalindrome + k < s.Length; k++)
                    {
                        if (s[middleOfPalindrome - k] == s[middleOfPalindrome + k])
                        {
                            short lowerBound = (short)(middleOfPalindrome - k);
                            short upperBound = (short)(middleOfPalindrome + k);
                            if ((upperBound - lowerBound) >= (highestBound - lowestBound))
                            {
                                lowestBound = lowerBound;
                                highestBound = upperBound;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (middleOfPalindrome > 0 &&
                        (s[middleOfPalindrome - 1] == s[middleOfPalindrome]))
                    {
                        short lowerBound = (short)(middleOfPalindrome - 1);
                        short upperBound = middleOfPalindrome;
                        while (lowerBound > 0 &&
                               upperBound < s.Length - 1 &&
                               s[lowerBound - 1] == s[upperBound + 1])
                        {
                            lowerBound--;
                            upperBound++;
                        }
                        if ((upperBound - lowerBound) >= (highestBound - lowestBound))
                        {
                            lowestBound = lowerBound;
                            highestBound = upperBound;
                        }
                    }
                }
            }
            return s.Substring(lowestBound, highestBound - lowestBound + 1);
        }
        static void Main(string[] args)
        {
            string example = "abb";
            System.Console.WriteLine(LongestPalindrome(example));
        }
    }
}
