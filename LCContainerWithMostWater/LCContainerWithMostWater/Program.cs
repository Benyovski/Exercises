namespace LCContainerWithMostWater
{
    public class Program
    {
        /// <summary>
        /// A function to find the maximum area of water that can be contained in a container; Approach: Brute Force. Unoptimal, does not pass all test cases.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxAreaBeta(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    int area = Math.Min(height[i], height[j]) * (j - i);
                    maxArea = Math.Max(maxArea, area);
                }
            }
            return maxArea;
        }
        /// <summary>
        /// A function to find the maximum area of water that can be contained in a container; Approach: Two Pointer. Optimal, passes all test cases.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, area);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
