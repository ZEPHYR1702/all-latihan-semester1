namespace all_latihan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a test: ");
            int.TryParse(Console.ReadLine(), out int test);

            Console.WriteLine($"i give you {test}");
        }
    }
}
