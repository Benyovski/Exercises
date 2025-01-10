namespace CDWSMoveZeroesToTheEnd
{
    public class Program
    {
        /// <summary>
        /// A function that moves all zeroes to the end of an array without changing the order of non-zero elements.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> result = arr.ToList();
            int zeroCount = result.Count(x => x == 0);
            result.RemoveAll(x => x == 0);
            for (int i = 0; i < zeroCount; i++)
            {
                result.Add(0);
            }
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
