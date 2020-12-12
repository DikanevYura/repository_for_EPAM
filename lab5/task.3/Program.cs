using System;

namespace task._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter integer (0 to 11): ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Month in enum, corresponding to that number: {(Months)n}");

            Console.ReadKey();
        }
    }
}
