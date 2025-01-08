namespace CDWSDNAToRNA
{
    internal class Program
    {
        public string DnaToRna(string dna)
        {
            return dna.Replace('T', 'U');
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
