namespace Factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool userChoiceRepeatBool = true;
            int userNumber;
            string userChoiceRepeatString;
            string userNumberString;
            do
            {
                Console.WriteLine("Enter a number that is supposed to be factorised: ");
                userNumberString = Console.ReadLine();
                while (!int.TryParse(userNumberString, out userNumber))
                {
                    Console.WriteLine("Invalid input!");
                    userNumberString = Console.ReadLine();
                    if (int.TryParse(userNumberString, out userNumber))
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                bool isPrime = true;
                for (int i = 2; userNumber != 1; i++)
                {
                    if (userNumber % i == 0)
                    {
                        if (userNumber != i)
                        {
                            isPrime = false;
                        }
                        Console.Write(i + " ");
                        userNumber /= i;
                        while (userNumber % i == 0)
                        {
                            Console.Write(i + " ");
                            userNumber /= i;
                        }
                    }
                }
                if (isPrime)
                {
                    Console.Write("is a prime number");
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to factorise another number? Y/N");
                userChoiceRepeatString = Console.ReadLine();
                while (string.IsNullOrEmpty(userChoiceRepeatString) || !(new[] { "Y", "y", "N", "n" }.Contains(userChoiceRepeatString)))
                {
                    Console.WriteLine("Invalid input!");
                    userChoiceRepeatString = Console.ReadLine();
                }
                if (userChoiceRepeatString.Equals("N") || userChoiceRepeatString.Equals("n"))
                {
                    userChoiceRepeatBool = false;
                }
                else if (userChoiceRepeatString.Equals("Y") || userChoiceRepeatString.Equals("y"))
                {
                    userChoiceRepeatBool = true;
                }
                Console.Clear();
            } while (userChoiceRepeatBool);
        }
    }
}