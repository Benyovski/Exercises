namespace CDWSFindTheOddInt
{
    public class Program
    {
        /// <summary>
        /// A function that takes an array of integers and finds the one that appears an odd number of times.
        /// </summary>
        /// <param name="seq"></param>
        /// <returns></returns>
        public static int FindIt(int[] seq)
        {
            if (seq.Length == 1)
            {
                return seq[0];
            }
            for(int i = 0; i < seq.Length; i++)
            {
                if (seq.Where(x => x == seq[i]).Count() % 2 != 0)
                {
                    return seq[i];
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
