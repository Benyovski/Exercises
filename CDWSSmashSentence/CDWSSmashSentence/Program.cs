namespace CDWSSmashSentence
{
    internal class Program
    {
        public static string Smash(string[] words)
        {
            return string.Join(" ", words);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Smash(["Hello", "world", "I", "am", "Smashing"]));
        }
    }
}
