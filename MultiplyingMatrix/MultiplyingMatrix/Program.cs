namespace MultiplyingMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint userMultiplier;
            string userMultiplierString;
            bool inputNeededCorrection = false;
            Console.WriteLine("Provide the maximum multiplier: ");
            userMultiplierString = Console.ReadLine();
            while(!uint.TryParse(userMultiplierString, out userMultiplier) || userMultiplierString == "0")
            {
                inputNeededCorrection = true;
                Console.WriteLine("Invalid input!");
                userMultiplierString = Console.ReadLine();
                if(uint.TryParse(userMultiplierString,out userMultiplier) && userMultiplierString != "0")
                {
                    Console.WriteLine("You chose " + userMultiplier);
                    break;
                }
                else
                {
                    continue;
                }
            }
            if(uint.TryParse(userMultiplierString,out userMultiplier) && !inputNeededCorrection)
            {
                Console.WriteLine("You chose " + userMultiplier);
            }
            for(int i = 1; i <= userMultiplier; i++)
            {
                for(int j = 1; j <= userMultiplier; j++)
                {
                    Console.Write((i * j).ToString().PadRight(5));
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
