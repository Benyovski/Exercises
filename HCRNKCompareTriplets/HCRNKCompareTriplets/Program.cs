using System.Net;

namespace HCRNKCompareTriplets
{
    internal class Program
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int aliceScore = 0;
            int bobScore = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aliceScore++;
                }
                else if (a[i] < b[i])
                {
                    bobScore++;
                }
            }

            return new List<int> { aliceScore, bobScore };
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
