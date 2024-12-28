namespace Signum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte userInitialChoiceNumber;
            string userInitialChoiceString;
            string userNumberString;
            string userChoiceRepeatString;
            int userNumber;
            int computerNumber;
            long multiplyResult;
            bool userChoiceIsPositive = true;
            bool userChoiceRepeatBool = true;
            bool neededCorrection = false;
            Random rnd = new();
            do
            {
                Console.WriteLine("Do you want to bet on a negative number or on a positive number? 1 - Positive, 0 - negative");
                userInitialChoiceString = Console.ReadLine();
                while (!byte.TryParse(userInitialChoiceString, out userInitialChoiceNumber) || !(new[] { "1", "0" }.Contains(userInitialChoiceString)))
                {
                    neededCorrection = true;
                    Console.WriteLine("Invalid input! Provide a number that is either 1 or 0!");
                    userInitialChoiceString = Console.ReadLine();
                    if (byte.TryParse(userInitialChoiceString, out userInitialChoiceNumber))
                    {
                        if (new[] { 1, 0 }.Contains(userInitialChoiceNumber))
                        {
                            if (userInitialChoiceNumber == 1)
                            {
                                Console.WriteLine("You chose the positive numbers!");
                                userChoiceIsPositive = true;
                            }
                            if (userInitialChoiceNumber == 0)
                            {
                                Console.WriteLine("You chose the negative numbers!");
                                userChoiceIsPositive = false;
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if (userInitialChoiceNumber == 1)
                {
                    if (!neededCorrection)
                    {
                        Console.WriteLine("You chose positive numbers!");
                    }
                    userChoiceIsPositive = true;
                }
                if (userInitialChoiceNumber == 0)
                {
                    if (!neededCorrection)
                    {
                        Console.WriteLine("You chose the negative numbers!");
                    }
                    userChoiceIsPositive = false;
                }
                Console.WriteLine("Provide you chosen number: ");
                userNumberString = Console.ReadLine();
                while (!int.TryParse(userNumberString, out userNumber) || userNumberString.Equals("0"))
                {
                    Console.WriteLine("Invalid input! Enter a number that is not equal to 0!");
                    userNumberString = Console.ReadLine();
                    if (int.TryParse(userNumberString, out userNumber))
                    {
                        if (userNumber == 0)
                        {
                            Console.WriteLine("The provided number cannot be equal to 0!");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                userNumber = int.Parse(userNumberString);
                computerNumber = rnd.Next(int.MinValue, int.MaxValue);
                multiplyResult = computerNumber * userNumber;
                if (userChoiceIsPositive)
                {
                    if (multiplyResult < 0)
                    {
                        Console.WriteLine("You lost!");
                    }
                    if (multiplyResult > 0)
                    {
                        Console.WriteLine("You won!");
                    }
                }
                if (!userChoiceIsPositive)
                {
                    if (multiplyResult < 0)
                    {
                        Console.WriteLine("You won!");
                    }
                    if (multiplyResult > 0)
                    {
                        Console.WriteLine("You lost!");
                    }
                }
                Console.WriteLine("Do you want to play again? Y/N");
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
