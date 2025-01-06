namespace CDWSStringEndsWith
{
    public class Program
    {
        /// <summary>
        /// This function checks if the string ends with the given ending. 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ending"></param>
        /// <returns></returns>
        public static bool Solution(string str, string ending)
        {
            if (str.Length < ending.Length)
            {
                return false;
            }
            if (str.Length != 0 && ending.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < ending.Length; i++)
            {
                if (str[str.Length - ending.Length + i] != ending[i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
