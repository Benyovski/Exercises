namespace Fibonacci
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            if(n == 2)
            {
                return 2;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            bool inputNeededCorrection = false;
            uint userNumber;
            string userNumberString;
            Console.WriteLine("Provide a number denoting how many numbers of the Fibonacci Sequence should be displayed: ");
            userNumberString = Console.ReadLine();
            while(!uint.TryParse(userNumberString, out userNumber) || userNumberString.Equals("0"))
            {
                inputNeededCorrection = true;
                Console.WriteLine("Input invalid!");
                userNumberString = Console.ReadLine();
                if(uint.TryParse(userNumberString, out userNumber) && !userNumberString.Equals("0"))
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (!inputNeededCorrection)
            {
                userNumber = uint.Parse(userNumberString);
            }
            for(int i = 1; i <= userNumber; i++)
            {
                Console.Write(Fibonacci(i).ToString().PadRight(5));
            }
        }
    }
}
