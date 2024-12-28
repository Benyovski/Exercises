using System.Formats.Asn1;

namespace Bifactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint userNumber;
            uint bifactorialResult = 1;
            string userNumberString;
            bool inputNeededCorrection = false;
            bool inputEven;
            Console.WriteLine("Provide a number: ");
            userNumberString = Console.ReadLine();
            while(!uint.TryParse(userNumberString, out userNumber) || userNumberString.Equals("0"))
            {
                inputNeededCorrection = true;
                Console.WriteLine("Invalid input!");
                userNumberString = Console.ReadLine();
                if (uint.TryParse(userNumberString, out userNumber) && !userNumberString.Equals("0"))
                {
                    Console.WriteLine($"You chose: {userNumber}");
                    break;
                }
                else
                {
                    continue;
                }
            }
            if (!inputNeededCorrection)
            {
                if(uint.TryParse(userNumberString, out userNumber))
                {
                    Console.WriteLine($"You chose: {userNumber}");
                }
            }
            if (userNumber % 2 == 0)
            {
                inputEven = true;
            }
            else
            {
                inputEven = false;
            }
            for(uint i = 1; i <= userNumber; i++)
            {
                if (inputEven)
                {
                    if(i % 2 == 0)
                    {
                        bifactorialResult *= i;
                    }
                }
                else
                {
                    if(i % 2 == 1)
                    {
                        bifactorialResult *= i;
                    }
                }
            }
            Console.WriteLine($"Bifactorial of {userNumber} is {bifactorialResult}");
        }
    }
}
