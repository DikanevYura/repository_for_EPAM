using System;
using System.Collections.Generic;
using System.Text;

namespace task._3
{
    class Rectangle : Figure
    {
        public Rectangle(float x, float y) : base(x, y)
        {

        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}