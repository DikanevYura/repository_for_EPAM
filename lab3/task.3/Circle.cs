using System;
using System.Collections.Generic;
using System.Text;

namespace task._3
{
    class Circle
    {
        private static float _pi = 3.141592f;

        public static float GetLength(float radius)
        {
            return 2 * _pi * radius;
        }

        public static float GetArea(float radius)
        {
            return radius * radius * _pi;
        }

    }
}