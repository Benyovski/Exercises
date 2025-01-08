namespace CDWSMultiplicativePersistence
{
    public class Program
    {
        /// <summary>
        /// A method that takes a positive parameter n and returns its multiplicative persistence, which is the number of times you must multiply the digits in n until you reach a single digit.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Persistence(long n)
        {
            if (n < 10)
            {
                return 0;
            }
            int product = 1;
            string[] digits = n.ToString().ToCharArray().Select(c => c.ToString()).ToArray();
            for (int i = 0; i < digits.Length; i++)
            {
                product *= int.Parse(digits[i]);
            }
            if(product < 10)
            {
                return 1;
            }
            else
            {
                return 1 + Persistence(product);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(999).ToString());
        }
    }
}
