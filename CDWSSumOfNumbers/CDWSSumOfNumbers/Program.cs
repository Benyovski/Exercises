namespace CDWSSumOfNumbers
{
    public class Program
    {
        public static int GetSum(int a, int b)
        {
            int sum = default;
            if (a == b)
            {
                sum = a;
            }
            else if (a < b)
            {
                for(int i = a; i <= b; i++)
                {
                    sum += i;
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
