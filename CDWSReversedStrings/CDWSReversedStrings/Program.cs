namespace CDWSReversedStrings
{
    internal class Program
    {
        public static string Solution(string str)
        {
            return string.Concat(str.Reverse());
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solution("world"));
        }
    }
}
