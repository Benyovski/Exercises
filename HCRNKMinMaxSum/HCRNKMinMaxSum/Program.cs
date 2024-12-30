namespace HCRNKMinMaxSum
{
    public class Program
    {
        public static void MinMaxSum(List<int> arr)
        {
            long minSum = long.MaxValue;
            long maxSum = long.MinValue;
            long totalSum = default;
            int n = arr.Count;
            for (int i = 0; i < n; i++)
            {
                totalSum += arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                long currentSum = totalSum - arr[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < minSum)
                {
                    minSum = currentSum;
                }
            }
            Console.WriteLine(minSum + " " + maxSum);
        }

        static void Main(string[] args)
        {
            List<int> list = [1, 2, 3, 4, 5];
            HCRNKMinMaxSum.Program.MinMaxSum(list);
        }
    }
}
