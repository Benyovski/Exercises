namespace HCRNKCandles
{
    public class Program
    {
        public static int BirthdayCakeCandles(List<int> candles)
        {
            int sum = default;
            int maximumCandleHeight = candles.Max();
            foreach (int candle in candles)
            {
                if(candle == maximumCandleHeight)
                {
                    sum++;
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
