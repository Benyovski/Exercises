namespace LCMedianOfTwoSortedArrays
{
    public class Program
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] results = nums1.Concat(nums2).OrderBy(x => x).ToArray();
            int length = results.Length;
            if (length % 2 == 0)
            {
                return (results[(length / 2) - 1] + results[length / 2]) / 2.0;
            }
            else
            {
                return results[length / 2];
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
