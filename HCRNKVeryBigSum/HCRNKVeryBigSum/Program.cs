namespace HCRNKVeryBigSum
{
    internal class Program
    {

        public static long aVeryBigSum(List<long> arr)
        {
            long sum = 0;
            foreach (long i in arr)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
