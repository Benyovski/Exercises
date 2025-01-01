using System.Text;
using System.Linq;

namespace LCZigZagConversion
{
    public class Program
    {
        public static string Convert(string s, int numRows)
        {
            if (numRows == 1 || s.Length == 1)
            {
                return s;
            }
            string[] solution = new string[numRows];
            int counter = 0;
            int direction = 1;
            foreach (char ch in s)
            {
                solution[counter] += ch;
                counter += direction;
                if ((counter % (numRows - 1) == 0) || counter == 0)
                {
                    direction *= -1;
                }
            }

            return string.Concat(solution);
        }
        static void Main(string[] args)
        {
            string s = "PAYPALISHIRING";
            int numRows = 3;
            string result = Convert(s, numRows);
        }
    }
}
