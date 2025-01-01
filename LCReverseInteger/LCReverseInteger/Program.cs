namespace LCReverseInteger
{
    public class Program
    {
        public static int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                double remainder = x % 10;
                double temp = result * 10 + remainder;
                if ((temp - remainder) / 10 != result)
                {
                    return 0;
                }
                result = (int)temp;
                x /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
