namespace DNA
{
    internal class Program
    {
        static void Main(string[] args)
        {        

            Console.Write("indtast DNA1");
            string DNA1 = Console.ReadLine().ToUpper();
            Console.Write("indtast DNA2");
            string DNA2 = Console.ReadLine().ToUpper();

            DnaCalculator calculator = new DnaCalculator();
            Console.WriteLine($"\n\nThe hamming distance is {calculator.HammingDistance(DNA1, DNA2)}");




        }
    }
}
