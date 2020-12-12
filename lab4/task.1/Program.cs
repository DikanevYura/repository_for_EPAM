using System;

namespace task._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Square sq = new Square();

            sq.Draw();
            rect.Draw();

            Console.ReadKey();
        }
    }
}