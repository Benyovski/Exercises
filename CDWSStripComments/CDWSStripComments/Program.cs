using System.Text;

namespace CDWSStripComments
{
    public class Program
    {
        public static string StripComments(string text, string[] commentSymbols)
        {
            StringBuilder result = new();
            string[] lines = text.Split(Environment.NewLine);
            foreach (string line in lines)
            {
                string newLine = line;
                if (string.IsNullOrWhiteSpace(line))
                {
                    result.Append("\n");
                    continue;
                }
                foreach (string commentSymbol in commentSymbols)
                {
                    int indexOfASymbol = line.IndexOf(commentSymbol);
                    if (indexOfASymbol >= 0)
                    {
                        newLine = line.Substring(0, indexOfASymbol);
                        if (string.IsNullOrWhiteSpace(newLine))
                        {
                            result.Append("\n");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                if(!string.IsNullOrWhiteSpace(newLine))
                {
                    result.Append(newLine.TrimEnd() + "\n");
                }
            }
            result.Remove(result.Length - 1, 1);
            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
