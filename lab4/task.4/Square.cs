using System;
using System.Collections.Generic;
using System.Text;

namespace task._4
{
    class Square : Figure, IDrawable
    {
        public Square(float x, float y) : base(x, y)
        {

        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Square");
        }
    }
}