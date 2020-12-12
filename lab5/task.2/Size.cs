using System;
using System.Collections.Generic;
using System.Text;

namespace task._2
{
    interface ISize
    {
        double Width { get; set; }
        double Height { get; set; }

        double Perimeter();
    }
}
