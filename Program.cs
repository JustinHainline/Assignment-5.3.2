namespace Assignment_5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of steps: ");
            long n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n} has {CountWays(n)}");
        }
        public static long CountWays(long n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return CountWays(n - 1) + CountWays(n - 2);
        }
        
    }
}
