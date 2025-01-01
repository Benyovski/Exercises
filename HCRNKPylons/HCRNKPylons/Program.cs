namespace HCRNKPylons
{
    public class Program
    {
        #region PylonsBeta
        public static int PylonsBeta(int k, List<int> arr)
        {
            int n = arr.Count;
            List<int> zeroIndexes = new();
            List<int> oneIndexes = new();
            List<int> suppliedZeroIndexes = new();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 1)
                {
                    oneIndexes.Add(i);
                }
                else
                {
                    zeroIndexes.Add(i);
                }
            }
            if (oneIndexes.Count == 0)
            {
                return -1;
            }
            for (int i = 0; i < zeroIndexes.Count; i++)
            {
                for (int j = 0; j < oneIndexes.Count; j++)
                {
                    if (Math.Abs(zeroIndexes[i] - oneIndexes[j]) < k)
                    {
                        if (!suppliedZeroIndexes.Contains(zeroIndexes[i]))
                        {
                            suppliedZeroIndexes.Add(zeroIndexes[i]);
                        }
                    }
                }
            }
            if (suppliedZeroIndexes.Count < zeroIndexes.Count)
            {
                return -1;
            }
            List<int> neededPowerPlants = new(oneIndexes);
            for (int i = 0; i < neededPowerPlants.Count; i++)
            {
                for (int j = 0; j < suppliedZeroIndexes.Count; j++)
                {
                    if (Math.Abs(neededPowerPlants[i] - suppliedZeroIndexes[j]) > k)
                    {
                        neededPowerPlants.RemoveAt(i);
                    }
                }
            }
            bool oneSupplied = false;
            for (int i = 0; i < oneIndexes.Count; i++)
            {
                for (int j = 0; j < neededPowerPlants.Count; j++)
                {
                    if (Math.Abs(oneIndexes[i] - neededPowerPlants[j]) < k)
                    {
                        oneSupplied = true;
                        break;
                    }
                }
                if (!oneSupplied)
                {
                    neededPowerPlants.Add(oneIndexes[i]);
                }
                oneSupplied = false;
            }
            return neededPowerPlants.Count;
        }
        #endregion

        public static int Pylons(int k, List<int> arr)
        {
            int counter = default;
            int index = default;
            int n = arr.Count;
            int notCovered = 1;
            int lastAvailable = -1;
            while (index < n)
            {
                if (arr[index] == 1)
                {
                    lastAvailable = index;
                }
                if (notCovered >= k)
                {
                    if (lastAvailable == -1)
                    {
                        return -1;
                    }
                    notCovered = -(k - 1) + (index - lastAvailable) + 1;
                    counter++;
                    index++;
                    lastAvailable = -1;
                }
                else if (index == n - 1)
                {
                    if (notCovered > 0)
                    {
                        if (lastAvailable == -1)
                        {
                            return -1;
                        }
                        if ((n - 1) <= (lastAvailable + (k - 1)))
                        {
                            counter++;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    index++;
                }
                else
                {
                    notCovered++;
                    index++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
            {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HackerRank Pylons");
            Console.ForegroundColor = defaultColor;
            }
        }
    }
