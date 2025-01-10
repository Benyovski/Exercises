using System.Numerics;

namespace CDWSAddingTwoBigIntegers
{
    internal class Program
    {
        public static string Add(string a, string b)
        {
            BigInteger aInt = BigInteger.Parse(a);
            BigInteger bInt = BigInteger.Parse(b);
            BigInteger resultInt = aInt + bInt;
            return resultInt.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
