namespace CDWSHighestAndLowestFromString
{
    public class Program
    {
        public static string HighAndLow(string numbers)
        {
            List<int> numbersList = [];
            foreach (string number in numbers.Split(' '))
            {
                numbersList.Add(int.Parse(number));
            }
            return $"{numbersList.Max()} {numbersList.Min()}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
