namespace HCRNKDiagonalDifference
{
    internal class Program
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int d1 = default;
            int d2 = default;
            for (int i = 0; i < arr.Count; i++)
            {
                d1 += arr[i][i];
                d2 += arr[i][arr.Count - i - 1];
            }
            return Math.Abs(d1 - d2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
