using System.ComponentModel;

namespace HCRNKTimeConversion
{
    internal class Program
    {
        public static string TimeConverter(string s)
        {
            DateTime time = Convert.ToDateTime(s);
            return time.ToString("HH:mm:ss");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TimeConverter("7:12:44PM").ToString());
        }
    }
}
