namespace LCTwoSum
{
    internal class Program
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return [];
        }
        static void Main(string[] args)
        {
            int[] nums = [2, 7, 11, 15];
            int desiredSum = 9;
            int[] solution = TwoSum(nums, desiredSum);
            for (int i = 0; i < solution.Length; i++)
            {
                Console.WriteLine(solution[i]);
            }
        }
    }
}
