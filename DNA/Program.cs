namespace DNA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first DNA sequence: ");
            string dna1 = Console.ReadLine().ToLower();
            Console.WriteLine("Inpute second DNA sequence: ");
            string dna2 = Console.ReadLine().ToLower();

            Dna dna = new Dna();
            //This method adds difference in length to the number of differing letters.
            int hammingDistance = dna.CompareDna(dna1, dna2);
            Console.WriteLine($"The hamming-distance is {hammingDistance}");
        }
    }
}
