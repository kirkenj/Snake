using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal interface ISnake : IDrawable
    {
        Direction Direction { get; set; }
        List<Point> Points { get; }
    }
}
