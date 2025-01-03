namespace LCLongestCommonPrefix
{
    public class Program
    {

        /// <summary>
        /// A function to find the longest common prefix string amongst an array of strings. If there is no common prefix, it returns an empty string "". 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            int minLength = int.MaxValue;
            foreach (string str in strs)
            {
                if (str.Length < minLength)
                {
                    minLength = str.Length;
                }
            }
            System.Text.StringBuilder longestCommonPrefix = new();
            for (int i = 0; i < minLength; i++)
            {
                char common = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != common)
                    {
                        return longestCommonPrefix.ToString();
                    }
                }
                longestCommonPrefix.Append(common);
            }
            return longestCommonPrefix.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
