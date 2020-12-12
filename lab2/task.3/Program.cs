using System;

namespace task._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            var input = Console.ReadLine().Replace('a', 'u');
            Console.WriteLine($"String with 'a' replaced by 'u': {input}");
            Console.ReadKey();
        }
    }
}