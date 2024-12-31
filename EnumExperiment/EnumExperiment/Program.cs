namespace EnumExperiment
{
    internal class Program
    {
        enum DaysOfWeekEnum : byte
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            DaysOfWeekEnum day = DaysOfWeekEnum.Monday;
            Console.WriteLine(Enum.GetUnderlyingType(day.GetType()));
            Console.WriteLine($"{day.ToString()} = {(byte)day}");
        }
    }
}
