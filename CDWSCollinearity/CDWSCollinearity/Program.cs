namespace CDWSCollinearity
{
    public class Program
    {
        /// <summary>
        /// Check if two lines are collinear.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static bool Collinearity(int x1, int y1, int x2, int y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                return true;
            }
            if ((x1 == 0 && y1 == 0) || (x2 == 0 && y2 == 0))
            {
                return true;
            }
            return x1 * y2 == x2 * y1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
