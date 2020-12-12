using System;

namespace task._2
{
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter edge length: ");
        var edgeLength = float.Parse(Console.ReadLine());
        var volume = edgeLength * edgeLength * edgeLength;
        Console.WriteLine($"Volume of cube: {volume}");
        Console.ReadLine();
    }
}
}