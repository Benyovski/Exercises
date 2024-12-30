namespace LCLongestSubstring
{
    internal class Program
    {
        public static int LongestSubstring(string s)
        {
            int len = s.Length;
            int tempLength = 0;
            List<int> listLength = new List<int>();
            if (len == 0)
            {
                return 0;
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    if (!s.Substring(i, j - i).Contains(s[j]))
                    {
                        tempLength++;
                    }
                    else
                    {
                        break;
                    }
                }
                listLength.Add(tempLength);
                tempLength = 0;
            }

            return listLength.Max();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LongestSubstring("abcabcbb").ToString());
        }
    }
}
