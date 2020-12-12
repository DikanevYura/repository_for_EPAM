using System;
using System.Collections.Generic;
using System.Text;

namespace task._2
{
    abstract class Figure
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        protected Figure(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract void Draw();
    }
}