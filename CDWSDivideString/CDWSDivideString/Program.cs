namespace CDWSDivideString
{
    public class Program
    {
        public static string[] Solution(string str)
        {
            if(str.Length == 0)
            {
                return [];
            }
            List<string> temp = string.Join("", str).Select(x => x.ToString()).ToList();
            List<string> result = new();
            if (temp.Count % 2 == 0)
            {
                for (int i = 0; i < temp.Count; i += 2)
                {
                    result.Add(temp[i] + temp[i + 1]);
                }
            }
            else
            {
                for (int i = 0; i < temp.Count - 1; i += 2)
                {
                    result.Add(temp[i] + temp[i + 1]);
                }
                result.Add(temp[temp.Count - 1] + "_");
            }
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            string test = "abc";
            string[] result = Solution(test);
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
