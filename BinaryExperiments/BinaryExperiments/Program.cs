namespace BinaryExperiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{int.MaxValue:D}");
            Console.WriteLine($"{(long.MaxValue).GetType().ToString()}");
            Console.WriteLine($"{int.MaxValue << 1:b} = {int.MaxValue << 1:D}");
            Console.WriteLine($"{(int.MaxValue << 33).GetType().ToString()}");
            Console.WriteLine($"{short.MaxValue << 10:b} = {short.MaxValue << 3:D}");
            Console.WriteLine($"{short.MinValue:b} = {short.MinValue:D}");
        }
    }
}
