namespace HCRNKPlusMinus
{
    internal class Program
    {
        public static void PlusMinus(List<int> arr)
        {
            float positive = 0;
            float negative = 0;
            float zero = 0;
            float total = arr.Count;
            foreach (float item in arr)
            {
                if (item > 0)
                {
                    positive++;
                }
                else if (item < 0)
                {
                    negative++;
                }
                else
                {
                    zero++;
                }
            }
            Console.WriteLine((float)positive / total);
            Console.WriteLine((float)negative / total);
            Console.WriteLine((float)zero / total);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
