namespace HCRNKStaircase
{
    internal class Program
    {
        public static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }

        static void Main(string[] args)
        {
            Staircase(10);
        }
    }
}
