namespace CDWSArrayDifference
{
    public class Program
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> aList = a.ToList();
            List<int> bList = b.ToList();
            List<int> result = new();
            foreach (int i in aList)
            {
                if (!bList.Contains(i))
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        } 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
