using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }
        char Sym { get; set; }


        bool IsHit(Point point);
    }
}
