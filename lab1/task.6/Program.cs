using System;

namespace task._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a float-point number: ");
            var input = float.Parse(Console.ReadLine());
            var result = (float)Math.Sqrt(Math.Ceiling(input));
            Console.WriteLine($"Result is: {result}");
            Console.ReadKey();
        }
    }
}