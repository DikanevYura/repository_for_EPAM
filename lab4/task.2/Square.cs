using System;
using System.Collections.Generic;
using System.Text;

namespace task._2
{
    class Square : Figure
    {
        public Square(float x, float y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}
