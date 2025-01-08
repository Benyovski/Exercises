namespace CDWSDisemvowel
{
    internal class Program
    {
        public static string Disemvowel(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return new string(str.Where(c => !vowels.Contains(c)).ToArray());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
