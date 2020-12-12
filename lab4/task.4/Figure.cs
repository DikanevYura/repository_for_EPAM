using System;
using System.Collections.Generic;
using System.Text;

namespace task._4
{
    class Figure : IDrawable
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Figure(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        void IDrawable.Draw()
        {
            Console.WriteLine("Figure");
        }
    }
}