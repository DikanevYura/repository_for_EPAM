using System;
using System.Collections.Generic;
using System.Text;

namespace task._4
{
    class Rectangle : Figure, IDrawable
    {
        public Rectangle(float x, float y) : base(x, y)
        {

        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
