using System.Net;

namespace HCRNKSumOfArray
{
    internal class Program
    {
        public static int SumOfArray(List<int> arr)
        {
            int sum = 0;
            foreach (int i in arr)
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
