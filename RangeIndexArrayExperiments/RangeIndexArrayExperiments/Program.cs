namespace RangeIndexArrayExperiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            Index index = 3;
            Index indexFromEnd = ^3;
            Range range = index..indexFromEnd;
            int[] subArray = array[range];
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (int i in subArray)
            {
                Console.WriteLine(i);
            } 
            Console.ForegroundColor = color;
        }
    }
}
